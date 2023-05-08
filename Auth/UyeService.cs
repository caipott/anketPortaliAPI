using anketPortaliAPI.Models;
using anketPortaliAPI.ViewModel;
using System.Linq;

namespace anketPortaliAPI.Auth
{
    public class UyeService
    {
        anketPortaliDBEntities db = new anketPortaliDBEntities();

        public userModel UyeOturumAc(string kadi, string parola)
        {
            userModel uye = db.Uye.Where(s => s.KullaniciAdi == kadi && s.Sifre == parola).Select(x => new userModel()
            {
                user_id = x.user_id,
                name = x.name,
                email = x.email,
                password = x.password,
                admin = x.admin
            }).SingleOrDefault();
            return uye;

        }
    }
}
