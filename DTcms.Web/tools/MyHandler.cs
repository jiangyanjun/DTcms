using System;
using System.Web;
/// <summary>
///MyHandler 的摘要说明
/// </summary>
public class MyHandler : IHttpHandler
{
    public void ProcessRequest(HttpContext ctx)//方法名固定
    {
        HttpResponse Response;
        ctx.Response.Write("路径错误，http://www.wafxw.cn/  ，Sorry");
    }
    bool IHttpHandler.IsReusable
    {
        get { return false; }
    }

}