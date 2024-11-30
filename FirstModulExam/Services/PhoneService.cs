using FirstModulExam.Models;

namespace FirstModulExam.Services
{
    internal class PhoneService
    {
        private List<Phone> phones;
        public PhoneService()
        {
            phones = new List<Phone>();
        }

        public Phone AddPhone(Phone phone)
        {
            phones.Add(phone);
            return phone;
        }
        public Phone GetById(Guid phoneId)
        {
            foreach (var phone in phones)
            {
                if (phone.Id == phoneId)
                {
                    return phone;
                }
            }
            return null;
        }
        public bool DeletedPhone(Guid deletedPhone)
        {
            var phoneDb = GetById(deletedPhone);
            if (phoneDb.Id == deletedPhone)
            {
                phones.Remove(phoneDb);
                return true;
            }
            return false;
        }
        public bool UpdatedPhone(Phone updatingPhone)
        {
            var phoneFromDb = GetById(updatingPhone.Id);
            if (phoneFromDb is null)
            {
                return false;
            }
            var index = phones.IndexOf(phoneFromDb);
            phones[index] = updatingPhone;
            return true;
        }
        public Phone GetAll(Phone phones)
        {
            return phones;
        }



    }
}