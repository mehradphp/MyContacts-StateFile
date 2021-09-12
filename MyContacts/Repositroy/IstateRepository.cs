using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MyContacts
{
    interface IstateRepository
    {

        DataTable SearchFile(string parameter);

        DataTable SearchPrice(string parameter1, string parameter2);

        DataTable SelectAll();

        DataTable SelectRow(int id);

        bool Insert(string codefile, string address, string namemalek, int price, string mobile,string categoryname);

        bool Update(int id, string codefile, string address, string namemalek, int price, string mobile, string categoryname);

        bool Delete(int id);

    }
}
