using LAB0_0.Helpers;

namespace LAB0_0.Models
{
    public class PersonModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Phone { get; set; }
        public string Description { get; set; }
        public bool Save()
        {
            try
            {
                Storage.Instance.personList.Add(this);
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}