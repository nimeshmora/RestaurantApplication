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

        public static String getLoginUserIDQuery() {
            return "select user_id from [dbo].[user] where user_name=@username and password=@password";
        }

        public static String getFoodTypeServeQuery() {

            return "select item_id,name,price from [dbo].[fooditem] where menu_type in (select food_type_id from [dbo].[foodtype] where type_name=@foodType)";
            //return "select food_type_id from [dbo].[foodtype] where type_name='Mains'";

        }

        public static String getFoodItemImageQuery() {

            return "select item_image from [dbo].[fooditem] where item_id=@itemId ";
        }

        public static String getMaxOrderId() {

            return "select max(order_id) from [dbo].[order]";
        }

        public static String getDateOfMaxOrderId() {

            return "select order_date from [dbo].[order] where order_id=@order_id";
        }

        public static String addOrderTempQuery() {
            return "insert into [dbo].[order](order_date,user_id) values(@order_date, @user_id)";
        }
        public static String addOrderItemQuery() {
            return "insert into [dbo].[orderitem] values(@order_id,@food_item_id,@food_item_quantity)";
        }

        public static String getOrderItemsValueForOrderQuery() {

            return "select sum(fd.price*ord.food_item_quantity) as amount from [dbo].[orderitem] ord inner join [dbo].[fooditem] fd on ord.food_item_id = fd.item_id where order_id =@max_id";
        }

        public static String updateOrderQuery() {
            return "update [dbo].[order] set order_date=@order_date, order_amount=@order_amount, user_id=@user_id where order_id=@max_id";
        }


        public static String getCustomerOrdersQuery()
        {

            return "select order_id , order_date from [dbo].[order] where user_id=@user_id and feedback_id is null";
        }


        public static String getAllTimeFoodQuantityQuery() {

            return "select menu_type, sum(food_item_quantity) as total from [dbo].[orderitem] ord inner join [dbo].[fooditem] fi on ord.food_item_id=fi.item_id group by menu_type";
        }

        public static String getLastThirtyDayFoodQuantityQuery()
        {

            return "select menu_type, sum(food_item_quantity) as total from [dbo].[orderitem] oi inner join [dbo].[fooditem] fi on oi.food_item_id=fi.item_id inner join [dbo].[order] ord on ord.order_id=oi.order_id where DATEDIFF(DAY,order_date,GETDATE()) between 0 and 30  group by menu_type";
        }

        public static String getLastSevenDayFoodQuantityQuery()
        {

            return "select menu_type, sum(food_item_quantity) as total from [dbo].[orderitem] oi inner join [dbo].[fooditem] fi on oi.food_item_id=fi.item_id inner join [dbo].[order] ord on ord.order_id=oi.order_id where DATEDIFF(DAY,order_date,GETDATE()) between 0 and 7  group by menu_type";
        }

        public static String addFeedBackForOrder() {

            return "insert into [dbo].[feedback](presentation, taste, timetoprepare, price, comment) values(@present, @taste, @timetoprepare, @price, @comment)";
        }

        public static String getMaxFeedID() {

            return "select max(feed_id) from [dbo].[feedback]";
        }

        public static String updateOrderTableWithAddedFeedID()
        {

            return "update [dbo].[order] set feedback_id=@feedMaxID where order_id=@selectedOrderID";
        }

    }
}
