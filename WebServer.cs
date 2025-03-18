using System;
using System.Net;
using System.Text;

class WebServer {
    static void Main() {
        HttpListener listener = new HttpListener();
        listener.Prefixes.Add("http://localhost:8080/");
        listener.Start();

        Console.WriteLine("🌍 Web server running on http://localhost:8080/");
        while (true) {
            var context = listener.GetContext();
            var response = context.Response;
            string responseString = "<html><body><h1>🚀 Hello from C# Web Server!</h1></body></html>";

            byte[] buffer = Encoding.UTF8.GetBytes(responseString);
            response.ContentLength64 = buffer.Length;
            response.OutputStream.Write(buffer, 0, buffer.Length);
            response.OutputStream.Close();
        }
    }
}
