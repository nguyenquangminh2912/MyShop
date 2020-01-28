
using System;
    namespace MyShop.Data.Infrastructer
{
    public  interface IDbFactory:IDisposable
    {
        //IDbFactory:IDisposable => lớp IDbFactory có áp dụng phương thức giải phóng bộ nhớ
        MyShopDBContext Init(); //Chỉ cần 1 phương thức để Init thằng DBContext.



    }
}
