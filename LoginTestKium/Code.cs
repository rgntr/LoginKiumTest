﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginTestKium
{
    public class Code
    {
        public readonly static TradeSection[] tradeSections = new TradeSection[13];
        public readonly static OrderSection[] orderSections = new OrderSection[6];
        public readonly static Searchgubun[] Searchgubuns = new Searchgubun[4];

        public class TradeSection
        {
            private string code;
            private string name;

            public TradeSection(string c, string n)
            {
                this.code = c;
                this.name = n;
            }

            public string Name
            {
                get
                {
                    return this.name;
                }
            }

            public string Code
            {
                get
                {
                    return this.code;
                }
            }

        }

        public class OrderSection
        {
            private int codeNum;
            private string name;

            public OrderSection(int c, string n)
            {
                this.codeNum = c;
                this.name = n;

            }

            public string Name
            {
                get
                {
                    return this.name;
                }
            }

            public int Code
            {
                get
                {
                    return this.codeNum;

                }

            }
        }

        public class Searchgubun
        {
            private int codeNum;
            private string name;

            public Searchgubun(int c, string n)
            {
                this.codeNum = c;
                this.name = n;

            }

            public string Name
            {
                get
                {
                    return this.name;
                }
            }

            public int Code
            {
                get
                {
                    return this.codeNum;

                }

            }
        }
        static Code()
        {
            Searchgubuns[0] = new Searchgubun(1, "외인기간별매매");
            Searchgubuns[1] = new Searchgubun(2, "외인연속매수");
            Searchgubuns[2] = new Searchgubun(3, "기존매수대상");
            Searchgubuns[3] = new Searchgubun(4, "외국계창구매매상위");

            orderSections[0] = new OrderSection(1, "신규매수");
            orderSections[1] = new OrderSection(1, "신규매도");
            orderSections[2] = new OrderSection(1, "매수취소");
            orderSections[3] = new OrderSection(1, "매도취소");
            orderSections[4] = new OrderSection(1, "매수정정");
            orderSections[5] = new OrderSection(1, "매도정상");

            tradeSections[0] = new TradeSection("00","지정가");
            tradeSections[1] = new TradeSection("03", "시장가");
            tradeSections[2] = new TradeSection("05", "조건부지정가");
            tradeSections[3] = new TradeSection("06", "최유리지정가");
            tradeSections[4] = new TradeSection("07", "최우선지정가");
            tradeSections[5] = new TradeSection("10", "지정가IOC");
            tradeSections[6] = new TradeSection("13", "시장가IOC");
            tradeSections[7] = new TradeSection("16", "최유리IOC");
            tradeSections[8] = new TradeSection("20", "지정가FOK");
            tradeSections[9] = new TradeSection("23", "시장가FOK");
            tradeSections[10] = new TradeSection("26", "최유리FOK");
            tradeSections[11] = new TradeSection("61", "시간외단일가매매");
            tradeSections[12] = new TradeSection("81", "시간외종가");
            


        }

    }
}
