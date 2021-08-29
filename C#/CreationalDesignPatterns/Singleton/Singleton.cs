using System;
public sealed class Singleton
{
    //فیلد استاتیک از نوع کلاس برای نگهداری تنها نمونه از کلاس
    private static Singleton _instance = null;
    //اگر به صورت زیر نوشته شود نیازی به ایجاد در داخل تابع نمی باشد
    //و از داخل تابع می توان فقط  مقدار  فیلد را برگرداند
    //ولی ایجاد در داخل تابع باعث می شود در حافظه صرفه جویی شود 
    //و فقط در موقع نیاز شی ای از کلاس ایجاد شود
    // private static Singleton = new Singleton(); //Not Lazy Load
    //اگر فیلد را به صورت زیر تعریف کنید از نظر چند نخی نیز ایمن می شود
    //و نیاز نیست از دستور لاک در تابع استفاده شود
    // private readonly Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton(), true);
    private static object _lock = new object();
    //خصوصی سازی تابع سازنده برای جلوگیری از نمونه سازی از بیرون از کلاس
    // می تواند به صورت Protected هم باشد
    private Singleton()
    {
    }
    //متد استاتیکی که سازنده کلاس را بر میگرداند
    public static Singleton Instance()
    {
        //برای امن شدن در چند نخی 
        //ThreadSafe
        lock (_lock)
        {
            //کنترل میشود که اگر قبلا نمونه سازی انجام شده است دوباره نمونه سازی انجام نشود
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }

}