using System;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace Example3 {

  public class Echo : WebSocketService
  {
    protected override void OnMessage(MessageEventArgs e)
    {
      var msg = QueryString.Contains("name")
              ? String.Format("'{0}' returns to {1}", e.Data, QueryString["name"])
              : e.Data;
      Send(msg);
    }
  }
}
