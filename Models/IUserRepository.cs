using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OPG.Models
{
    public interface IUserRepository
    {
		Product SearchProduct(int ProductId);
		void Login(int UserId,string Password);
		void Rate();

	}
}
