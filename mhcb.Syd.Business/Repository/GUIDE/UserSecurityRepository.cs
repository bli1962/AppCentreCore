using System;
using System.Collections.Generic;
using System.Linq;
//using mhcb.syd.Encryption;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.DataAccess.Repository;
using mhcb.Syd.Interface;
using mhcb.Syd.Models;

namespace mhcb.Syd.Business.Repository
{
	public class UserSecurityRepository : IUserSecurity
	{
        //static string DecryptPassword(string encPassword)
        //{
        //    Encryption o = new Encryption();
        //    return o.Decrypt(encPassword).ToString();
        //}

        //static string EncryptPassword(string decPassword)
        //{
        //    Encryption o = new Encryption();
        //    return o.Encrypt(decPassword).ToString();
        //}

        private readonly GUIDEDbContext appDbContext;
        public UserSecurityRepository(GUIDEDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public User GetGUser(string userid, string decPassword)
		{

            //var queryUser = appDbContext.Users.Where(x => x.UserId.Equals(userid, StringComparison.OrdinalIgnoreCase))
            //                .Select(s => s.Password)
            //                .FirstOrDefault();

            //if (queryUser != null)
            //{
            //    var queryPW = appDbContext.Users.FirstOrDefault(x =>
            //                x.UserId.Equals(userid, StringComparison.OrdinalIgnoreCase)).Password.ToString();

            //    var decPassword2 = Krypting.Decrypt(queryPW);

            //    if (decPassword == decPassword2)
            //    {
            //        User user = appDbContext.Users.Where(x => x.UserId.Equals(userid, StringComparison.OrdinalIgnoreCase))
            //                    .FirstOrDefault();
            //        return user;
            //    }
            //    else
            //    {
            //        return null;
            //    }
            //}
            return null;

        }

		public bool Login(string userid, string decPassword)
		{

            //var queryUser = appDbContext.Users.Where(x => x.UserId.Equals(userid, StringComparison.OrdinalIgnoreCase))
            //            .Select(s => s.Password)
            //            .FirstOrDefault();

            //if (queryUser != null)
            //{
            //    var queryPW = appDbContext.Users.FirstOrDefault(x =>
            //                x.UserId.Equals(userid, StringComparison.OrdinalIgnoreCase)).Password.ToString();

            //    var decPassword2 = Krypting.Decrypt(queryPW);

            //    if (decPassword == decPassword2)
            //    {
            //        return appDbContext.Users.Any(x =>
            //            x.UserId.Equals(userid, StringComparison.OrdinalIgnoreCase) &&
            //            x.Password == queryUser);
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            return false;
        }

		public string GetAuthorization(string UserId)
		{
            //using GUIDEDbContext appDbContext  = new();
            var entry = (from b in appDbContext.UserSecurityGroups
                                   join c in appDbContext.SecurityGroups on b.SgIdentifier equals c.Identifier
                                   where (b.UserId == UserId) &&
                                    (
                                        c.Name.Contains("BIF - Authorise") ||
                                        c.Name.Contains("SIF - Authorise") ||
                                        c.Name.Contains("FX-Trans - Authorise") ||
                                        c.Name.Contains("FX-Delivery - Author") ||
                                        c.Name.Contains("Customer - Authorise") ||
                                        c.Name.Contains("Payment Control Auth") ||
                                        c.Name.Contains("Domestic Clearing Au") ||
                                        c.Name.Contains("EOD Authorise") ||
                                        c.Name.Contains("Money Market Modify")
                                    )
                                   select c.Name
                                   )
                                   .ToList();

            var p = "";
            if (entry != null)
            {
                p = string.Join(";", entry);
            }
            return p;
        }

        public IEnumerable<string> GetAuthorizations(string UserId)
        {
            //using GUIDEDbContext appDbContext  = new();
            var entry = (from b in appDbContext.UserSecurityGroups
                                   join c in appDbContext.SecurityGroups on b.SgIdentifier equals c.Identifier
                                   where (b.UserId == UserId) &&
                                    (
                                        c.Name.Contains("BIF - Authorise") ||
                                        c.Name.Contains("SIF - Authorise") ||
                                        c.Name.Contains("FX-Trans - Authorise") ||
                                        c.Name.Contains("FX-Delivery - Author") ||
                                        c.Name.Contains("Customer - Authorise") ||
                                        c.Name.Contains("Payment Control Auth") ||
                                        c.Name.Contains("Domestic Clearing Au") ||
                                        c.Name.Contains("EOD Authorise") ||
                                        c.Name.Contains("Money Market Modify")                                       
                                    )
                         select c.Name
                                   )
                                   .ToList();
            return entry;
        }
    }

}