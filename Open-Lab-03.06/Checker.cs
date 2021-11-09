using System;

namespace Open_Lab_03._06
{
    public class Checker
    {
        public bool HasSpaces(string str)
        {
            foreach (var item in str){
                if (item == ' '){
                    return true;}
            }
            return false;
        }
    }
}
