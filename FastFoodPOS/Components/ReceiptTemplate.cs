using FastFoodPOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodPOS.Components
{
    class ReceiptTemplate
    {

        public static string GetReceipt(Transaction transaction)
        {
            return GenerateReceiptTemplate()
                .Replace("<Orders/>", GetOrderRows(transaction))
                .Replace("<Total/>", transaction.Total.ToString() + "PHP")
                .Replace("<Cash/>", transaction.Cash.ToString() + "PHP")
                .Replace("<Change/>", transaction.Change.ToString() + "PHP")
                .Replace("<Id/>", transaction.Id)
                .Replace("<Cashier/>", transaction.GetCashier().Fullname)
                .Replace("<Date/>", transaction.Date.ToString());
        }

        static string GetOrderRows(Transaction transaction)
        {
            string result = "";
            transaction.GetOrders().ForEach((Order item) => {
                result += "<tr>";
                result += "<td>" + item.GetProduct().Name + "</td>";
                result += "<td align='center'>x " + item.Quantity + "</td>";
                result += "<td align='right'>" + item.Subtotal + "PHP</td>";
                result += "</tr>";
            });
            return result;
        }

        private static string GenerateReceiptTemplate()
        {
            return
                @"
                <center>
                    <font size='24px'><b>WcDonalds</b></font><br/>
                    <span>wcdonalds@gmail.com</span>
                </center>
                <br/><br/>
                <table width='100%'>
                    <thead>
                        <tr>
                            <th align='left'>Product Name</th>
                            <th>Quantity</th>
                            <th align='right'>Subtotal</th>
                        </tr>
                    </thead>
                    <tbody>
                        <Orders/>
                    </tbody>
                </table>
                <br/>
                <center>---------------------------------------</center>
                <br/>

                Total: <b><Total/></b><br/>
                Cash: <b><Cash/></b><br/>
                Change: <b><Change/></b><br/>
                <br/>
                Transaction ID: #<Id/><br/>
                Cashier: <Cashier/><br/>
                Date: <Date/><br/>

                <br/>
                <center>---------------------------------------</center>
                <br/>

                <center><b>Thanks for visiting WcDonalds</b></center>
                ";
        }
    }
}
