using System;

namespace Money
{
    class Money
    {
        public int grn { get; private set; }
        public int kop { get; private set; }

        public Money ()
        {
            grn = 0;
            kop = 0;
        }

        public Money(int grn, int kop)
        {
            if (kop >= 100 || kop < 0)
                throw new ArgumentException("Количество копеек должно быть от 0 до 99.");
            if (grn < 0)
                throw new ArgumentException("Банкрот!");
            this.grn = grn;
            this.kop = kop;

        }
        

    public override string ToString()
        {
            return string.Format("{0},{1:00}", grn, kop);
        }

        public static Money operator +(Money a, Money b)
        {
            int kopSum = a.kop + b.kop;
            int grn = a.grn + b.grn + kopSum / 100;
            int kop = (kopSum % 100);
            return new Money(grn, kop);
        }
        public static Money operator -(Money a, Money b)
        {
            int kopDiff = a.kop - b.kop;
            int grn = a.grn - b.grn;
            if (kopDiff < 0)
            {
                grn--;
                kopDiff += 100;
            }
            int kop = (kopDiff % 100);
            return new Money(grn, kop);
        }

        public static Money operator *(Money a, int b)
        {
            int grn = a.grn * b;
            grn += ((a.kop * b) / 100);
            int kop = ((a.kop * b) % 100);

            return new Money(grn, kop);
        }

        public static Money operator /(Money a, int b)
        {
            int grn = (((a.grn * 100) + a.kop) / b) / 100;
            int kop = (((a.grn * 100) + a.kop) / b) % 100;


            return new Money(grn, kop);
        }

        public static Money operator ++(Money a)
        {
            
            a.kop++;
            if (a.kop==100)
            {
                a.grn++;
                a.kop -= 100;
            }
            return a;
        }

        public static Money operator --(Money a)
        {

            a.kop--;
            if (a.kop == -1)
            {
                a.grn--;
                a.kop += 100;
            }
            return a;
        }

        public static bool operator <(Money a, Money b)
        {
            if (a.grn < b.grn)
            {
                return true;
            }
            else if (a.grn == b.grn)
            {
                if (a.kop < b.kop)
                {
                    return true;
                }
                else
                    return false;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(Money a, Money b)
        {
            if (a.grn > b.grn)
            {
                return true;
            }
            else if (a.grn == b.grn)
            {
                if (a.kop > b.kop)
                {
                    return true;
                }
                else
                    return false;
            }
            else
            {
                return false;
            }
        }


        public static bool operator ==(Money a, Money b)
        {
            if (a.grn == b.grn && a.kop == b.kop)
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator !=(Money a, Money b)
        {
            if (a.grn == b.grn && a.kop == b.kop)
            {
                return false;
            }
            else
                return true;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
