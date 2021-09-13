using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MyContacts
{
    interface IstateRepository
    {

        DataTable SearchFile(string parameter);

        DataTable SearchParams(int param1, int param2);
        DataTable SearchMetraj(int param1, int param2);

        DataTable SelectAll();

        DataTable SelectRow(int id);

        bool Insert(string codefile,int metraj, string address, string namemalek, int price, string mobile,string categoryname);

        bool Update(int id, string codefile,int metraj, string address, string namemalek, int price, string mobile, string categoryname);

        bool Delete(int id);

    }
}
