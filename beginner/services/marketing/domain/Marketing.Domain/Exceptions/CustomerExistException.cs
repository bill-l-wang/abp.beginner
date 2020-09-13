using Volo.Abp;

namespace Marketing.Domain.Exceptions
{
    public class CustomerExistException : BusinessException
    {
        public CustomerExistException(string mobile)
            : base("customer:000001", $"Customer with mobile {mobile} has already exists!")
        {

        }
    }
}
