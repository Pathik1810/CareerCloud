﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;

namespace CareerCloud.WCF
{
    public class Security : ISecurity
    {
        public void AddSecurityLogin(SecurityLoginPoco[] items)
        {
            var logic = new SecurityLoginLogic
                 (
                new EFGenericRepository<SecurityLoginPoco>(false)
               );
            logic.Add(items);
        }

        public void AddSecurityLoginsLog(SecurityLoginsLogPoco[] items)
        {
            var logic = new SecurityLoginsLogLogic
                 (
                new EFGenericRepository<SecurityLoginsLogPoco>(false)
               );
            logic.Add(items);
        }

        public void AddSecurityLoginsRole(SecurityLoginsRolePoco[] items)
        {
            var logic = new SecurityLoginsRoleLogic
                  (
                 new EFGenericRepository<SecurityLoginsRolePoco>(false)
                );
            logic.Add(items);
        }

        public void AddSecurityRole(SecurityRolePoco[] items)
        {
            var logic = new SecurityRoleLogic
                (
               new EFGenericRepository<SecurityRolePoco>(false)
              );
            logic.Add(items);
        }

       

        public List<SecurityLoginPoco> GetAllSecurityLogin()
        {
            var logic = new SecurityLoginLogic
             (new EFGenericRepository<SecurityLoginPoco>(false));
            return logic.GetAll();
        }

        public List<SecurityLoginsLogPoco> GetAllSecurityLoginsLog()
        {
            var logic = new SecurityLoginsLogLogic
             (new EFGenericRepository<SecurityLoginsLogPoco>(false));
            return logic.GetAll();
        }

        public List<SecurityLoginsRolePoco> GetAllSecurityLoginsRole()
        {
            var logic = new SecurityLoginsRoleLogic
            (new EFGenericRepository<SecurityLoginsRolePoco>(false));
            return logic.GetAll();
        }

        public List<SecurityRolePoco> GetAllSecurityRole()
        {
            var logic = new SecurityRoleLogic
             (new EFGenericRepository<SecurityRolePoco>(false));
            return logic.GetAll();
        }

        public SecurityLoginPoco GetSingleSecurityLogin(string Id)
        {
            SecurityLoginLogic logic = new SecurityLoginLogic
                 (new EFGenericRepository<SecurityLoginPoco>(false));
            return logic.Get(Guid.Parse(Id));
        }

        public SecurityLoginsLogPoco GetSingleSecurityLoginsLog(string Id)
        {
            SecurityLoginsLogLogic logic = new SecurityLoginsLogLogic
                 (new EFGenericRepository<SecurityLoginsLogPoco>(false));
            return logic.Get(Guid.Parse(Id));
        }

        public SecurityLoginsRolePoco GetSingleSecurityLoginsRole(string Id)
        {
            SecurityLoginsRoleLogic logic = new SecurityLoginsRoleLogic
                   (new EFGenericRepository<SecurityLoginsRolePoco>(false));
            return logic.Get(Guid.Parse(Id));
        }

        public SecurityRolePoco GetSingleSecurityRole(string Id)
        {
            SecurityRoleLogic logic = new SecurityRoleLogic
                 (new EFGenericRepository<SecurityRolePoco>(false));
            return logic.Get(Guid.Parse(Id));
        }

        public void RemoveSecurityLogin(SecurityLoginPoco[] items)
        {
            var logic = new SecurityLoginLogic
               (new EFGenericRepository<SecurityLoginPoco>(false));
            logic.Delete(items);
        }

        public void RemoveSecurityLoginsLog(SecurityLoginsLogPoco[] items)
        {
            var logic = new SecurityLoginsLogLogic
               (new EFGenericRepository<SecurityLoginsLogPoco>(false));
            logic.Delete(items);
        }

        public void RemoveSecurityLoginsRole(SecurityLoginsRolePoco[] items)
        {
            var logic = new SecurityLoginsRoleLogic
               (new EFGenericRepository<SecurityLoginsRolePoco>(false));
            logic.Delete(items);
        }

        public void RemoveSecurityRole(SecurityRolePoco[] items)
        {
            var logic = new SecurityRoleLogic
               (new EFGenericRepository<SecurityRolePoco>(false));
            logic.Delete(items);
        }

      

        public void UpdateSecurityLogin(SecurityLoginPoco[] items)
        {
            var logic = new SecurityLoginLogic
               (new EFGenericRepository<SecurityLoginPoco>(false));
            logic.Update(items);
        }

        public void UpdateSecurityLoginsLog(SecurityLoginsLogPoco[] items)
        {
            var logic = new SecurityLoginsLogLogic
                (new EFGenericRepository<SecurityLoginsLogPoco>(false));
            logic.Update(items);
        }

        public void UpdateSecurityLoginsRole(SecurityLoginsRolePoco[] items)
        {
            var logic = new SecurityLoginsRoleLogic
               (new EFGenericRepository<SecurityLoginsRolePoco>(false));
            logic.Update(items);
        }

        public void UpdateSecurityRole(SecurityRolePoco[] items)
        {
            var logic = new SecurityRoleLogic
               (new EFGenericRepository<SecurityRolePoco>(false));
            logic.Update(items);
        }

       
    }
}