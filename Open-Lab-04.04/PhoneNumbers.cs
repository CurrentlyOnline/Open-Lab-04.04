using System;

namespace Open_Lab_04._04
{
    public class PhoneNumbers
    {
        public string FormatPhoneNumber(int[] numbers)
        {
            string first3 = "(" + numbers[0] + numbers[1] + numbers[2] + ")";
            string last = " " + numbers[3] + numbers[4] + numbers[5] + "-" + numbers[6] + numbers[7] + numbers[8] + numbers[9];
            string finish = first3 + last;
            return finish;
        }

    }
}
