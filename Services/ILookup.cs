using Assessment.Model;

namespace Assessment.Services
{
    public interface ILookup
    {
        LocalGoverment GetStateWithLGA(string lga);
    }
}