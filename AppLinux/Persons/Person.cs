using System;

namespace AppLinux
{
    public interface Person
    {
        public bool setFirstname(string name);
        public bool setLastname(string name);
        public bool setAge(int age);
        public bool setSex(char sex);
        public string getFirstname();
        public string getLastname();
        public int getAge();
        public char getSex();

        public string ToString();
    }
}