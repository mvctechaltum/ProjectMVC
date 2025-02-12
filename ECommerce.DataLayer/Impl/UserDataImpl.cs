﻿using ECommerce.DataLayer.EDMX;
using ECommerce.DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataLayer.Impl
{
    public class UserDataImpl : BaseDataImpl, IUserRepository
    {
        public List<UserMaster> GetUser()
        {
            try
            {
                return EcommerceDbContext.UserMasters.ToList();
            }
            catch (Exception ex)
            {
                return new List<UserMaster>();
            }

        }

        public UserMaster UserLogin(string email, string password)
        {
            return EcommerceDbContext.UserMasters.Where(x => x.cemailaddress == email && x.cpassword == password).FirstOrDefault();
        }

        public int SubmitUser(UserMaster user)
        {
            EcommerceDbContext.UserMasters.Add(user);
            return EcommerceDbContext.SaveChanges();
        }

        public int GetUserRoleID(int userID)
        {
            return Convert.ToInt32(EcommerceDbContext.UserRoles.Where(x => x.UserID == userID).FirstOrDefault().RoleID);
        }
    }
}
