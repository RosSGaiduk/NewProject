﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Entity;

namespace HomeTask
{
    class PageService:ServiceAbstract
    {
        public void add(PageWithTextAndImage page)
        {
            command.CommandText = "INSERT INTO PageWithTextAndImage " +
               "(NumberOfPage,TextInPage) VALUES(?number,?text)";
            command.Prepare();
            command.Parameters.AddWithValue("?number", page.NumberOfPage);
            command.Parameters.AddWithValue("?text", page.TextInPage);
            command.ExecuteNonQuery();
        }

        public void delete(int id)
        {
            command.CommandText = "Delete from PageWithTextAndImage where id = ?id1";
            command.Prepare();
            command.Parameters.AddWithValue("?id1", id);
            command.ExecuteNonQuery();
        }

        public PageWithTextAndImage findOne(int id)
        {
            command.CommandText = "Select * from PageWithTextAndImage where id = ?id";
            command.Prepare();
            command.Parameters.AddWithValue("?id", id);
            reader = command.ExecuteReader();
            reader.Read();
            PageWithTextAndImage page;

            try
            {
                page = new PageWithTextAndImage(int.Parse(reader[0].ToString()), int.Parse(reader[1].ToString()), reader[2].ToString());
                reader.Close();
            }
            catch (Exception ex)
            {
                reader.Close();
                return null;
            }

            return page;
        }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public List<PageWithTextAndImage> findAll()
        {
            List<PageWithTextAndImage> pages = new List<PageWithTextAndImage>();
            command.CommandText = "Select * from PageWithTextAndImage";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                pages.Add(new PageWithTextAndImage(int.Parse(reader[0].ToString()), int.Parse(reader[1].ToString()), reader[2].ToString()));
            }
            reader.Close();
            return pages;
        }

    }
}
