using System;
using System.Collections.Generic;

namespace App.Controller
{
    public class Request
    {
        private Dictionary<string, string> data;

        public Request(Dictionary<string, string> data)
        {
            this.data = data;
        }

        public string Get(string key)
        {
            try {
                return this.data[key];
            } catch(System.Exception) {
                return "";
            }
        }
    }
}
