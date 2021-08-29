using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MyContacts
{
    interface IContactRepository
    {
        DataTable SelectAll();
        DataTable SelectRow(int contactId);

        DataTable Serach(string parameter);
        bool Insert(string name, string Family, string mobile, string email, int age, string address);
        bool update(int contactId,string name, string Family, string mobile, string email, int age, string address);
        bool Delete(int contactId);
    
    
    
    }
}
