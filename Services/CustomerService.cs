using Assessment.DbContext;
using Assessment.IServices;
using Assessment.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly AppDbContext _context;
        private readonly ILookup _lookup;
        private readonly IMapper _mapper;
        public CustomerService(AppDbContext context, ILookup lookup, IMapper mapper)
        {
            _context = context;
            _lookup = lookup;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            try
            {
                var customers = await _context.Customers.ToListAsync();

                return customers;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<Customer> AddCustomer(CustomerReg payload)
        {
            try
            {
                if (payload == null)
                {
                    throw new ArgumentException("Customer cannot be null");
                }
                if (!ValidateNo(payload.PhoneNo))
                {
                    throw new ArgumentException("Invalid phone number");
                }
                if (!SendOTP(payload.PhoneNo).Item1)
                {
                    throw new ArgumentException("Error Occur while sending OTP");
                }
                var lga = _lookup.GetStateWithLGA(payload.LGA);

                if (lga == null || payload.State.Trim().ToLower() != lga.State.StateName.Trim().ToLower())
                {
                    throw new ArgumentException("Invalid Local Government");
                }

                var model = new Customer(){
                Email = payload.Email,
                LGA = lga,
                OTPVerified = false,
                PhoneNo = payload.PhoneNo,
                State = lga.State,
                Password = payload.Password
                };
                model.State = lga.State;
                model.LGA = lga;
                await _context.Customers.AddAsync(model);
                await _context.SaveChangesAsync();
                return model;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private Tuple<bool, string> SendOTP( string phoneNo)
        {
            return new Tuple<bool, string>(true, "234253");
        }
        private bool ValidateOTP(string phoneNo, string otp)
        {
            return otp.Trim() == SendOTP(phoneNo).Item2.Trim();
        }
        private bool ValidateNo(string phoneNo)
        {
            if (string.IsNullOrWhiteSpace(phoneNo) || phoneNo.Length < 11)
            {
                return false;
            }
            if( !phoneNo.StartsWith("+234") && !phoneNo.StartsWith("234") && phoneNo.Length < 11)
            {
                return false;
            }
            for (int i = 0; i < phoneNo.Length; i++)
            {
                if (!Char.IsDigit(phoneNo[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
