using System;
using System.Collections.Generic;
using System.Text;

namespace Test4.ClassModel
{
    public class UserClass
    {
        public UserClass(string @class, string path)
        {
            Class = @class;
            Path = path;
        }

        public string Class { get; set; }
        public string Path { get; set; }

        public UserClass(string @class, string path)
        {
            Class = @class;
            Path = path;
        }
    }

}
