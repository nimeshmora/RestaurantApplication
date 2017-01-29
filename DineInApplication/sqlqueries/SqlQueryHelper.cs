using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DineInApplication.sqlqueries
{
    class SqlQueryHelper
    {

        public static String getLoginQuery() {

            return "select count(*) from [dbo].[user] where user_name=@username and password=@password";
        
        }

        public static String getFoodTypeServeQuery() {

            return "select item_id,name,price from [dbo].[fooditem] where menu_type in (select food_type_id from [dbo].[foodtype] where type_name=@foodType)";
            //return "select food_type_id from [dbo].[foodtype] where type_name='Mains'";

        }

        public static String getFoodItemImageQuery() {

            return "select item_image from [dbo].[fooditem] where item_id=@itemId ";
        }

        


    }
}
