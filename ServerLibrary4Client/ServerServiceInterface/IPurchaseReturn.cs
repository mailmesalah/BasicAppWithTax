using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace ServerServiceInterface
{    
    [ServiceContract]
    public interface IPurchaseReturn
    {
        [OperationContract]
        bool CreateBill(CPurchaseReturn oPurchaseReturn, string billType);
        [OperationContract]
        CPurchaseReturn ReadBill(string billNo, string billType, string financialCode);
        [OperationContract]
        CPurchaseReturn ReadPurchaseBill(string billNo, string billType, string financialCode);
        [OperationContract]
        bool UpdateBill(CPurchaseReturn oPurchaseReturn, string billType);
        [OperationContract]
        bool DeleteBill(string billNo, string billType, string financialCode);        
        [OperationContract]
        int ReadNextBillNo(string billType, string financialCode);

        [OperationContract]
        List<CPurchaseReturnReportSummary> FindPurchaseReturnSummary(DateTime startDate, DateTime endDate, string billType, string billNo, string supplierCode, string supplier, string productCode, string product, decimal tax, string narration, string financialCode);
        [OperationContract]
        List<CPurchaseReturnReportDetailed> FindPurchaseReturnDetailed(DateTime startDate, DateTime endDate, string billType, string billNo, string supplierCode, string supplier, string productCode, string product, decimal tax, string narration, string financialCode);
    }


    
    [DataContract]
    public class CPurchaseReturn
    {
        int id;
        string billNo;
        DateTime billDateTime = new DateTime();
        string refBillNo;
        DateTime refBillDateTime = new DateTime();
        string supplier;
        string supplierCode;
        string supplierAddress;
        string narration;
        decimal advance;
        decimal expense;
        decimal discount;
        string financialCode;
        List<CPurchaseReturnDetails> details= new List<CPurchaseReturnDetails>();
 
        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string BillNo
        {
            get { return billNo; }
            set { billNo = value; }
        }
        
        [DataMember]
        public DateTime BillDateTime
        {
            get { return billDateTime; }
            set { billDateTime = value; }
        }

        [DataMember]
        public string RefBillNo
        {
            get { return refBillNo; }
            set { refBillNo = value; }
        }

        [DataMember]
        public DateTime RefBillDateTime
        {
            get { return refBillDateTime; }
            set { refBillDateTime = value; }
        }

        [DataMember]
        public string Supplier
        {
            get { return supplier; }
            set { supplier = value; }
        }

        [DataMember]
        public string SupplierCode
        {
            get { return supplierCode; }
            set { supplierCode = value; }
        }

        [DataMember]
        public string SupplierAddress
        {
            get { return supplierAddress; }
            set { supplierAddress = value; }
        }

        [DataMember]
        public string Narration
        {
            get { return narration; }
            set { narration = value; }
        }

        [DataMember]
        public decimal Advance
        {
            get { return advance; }
            set { advance = value; }
        }

        [DataMember]
        public decimal Expense
        {
            get { return expense; }
            set { expense = value; }
        }

        [DataMember]
        public decimal Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        [DataMember]
        public string FinancialCode
        {
            get { return financialCode; }
            set { financialCode = value; }
        }

        [DataMember]
        public List<CPurchaseReturnDetails> Details
        {
            get { return details; }
            set { details = value; }
        }
    }


    [DataContract]
    public class CPurchaseReturnDetails
    {
        int serialNo;
        string productCode;
        string product;
        string purchaseUnit;
        string purchaseUnitCode;
        decimal purchaseUnitValue;
        decimal quantity;
        decimal tax;
        decimal grossValue;
        decimal netValue;
        decimal taxValue;
        decimal productDiscount;
        decimal purchaseRate;
        decimal interstateRate;
        decimal wholesaleRate;
        decimal mrp;
        string barcode;
        decimal total;
        decimal oldQuantity;

        [DataMember]
        public int SerialNo
        {
            get { return serialNo; }
            set { serialNo = value; }
        }

        [DataMember]
        public string ProductCode
        {
            get { return productCode; }
            set { productCode = value; }
        }

        [DataMember]
        public string Product
        {
            get { return product; }
            set { product = value; }
        }

        [DataMember]
        public string PurchaseReturnUnit
        {
            get { return purchaseUnit; }
            set { purchaseUnit = value; }
        }

        [DataMember]
        public string PurchaseReturnUnitCode
        {
            get { return purchaseUnitCode; }
            set { purchaseUnitCode = value; }
        }

        [DataMember]
        public decimal PurchaseReturnUnitValue
        {
            get { return purchaseUnitValue; }
            set { purchaseUnitValue = value; }
        }

        [DataMember]
        public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        [DataMember]
        public decimal Tax
        {
            get { return tax; }
            set { tax = value; }
        }

        [DataMember]
        public decimal ProductDiscount
        {
            get { return productDiscount; }
            set { productDiscount = value; }
        }

        [DataMember]
        public decimal PurchaseReturnRate
        {
            get { return purchaseRate; }
            set { purchaseRate = value; }
        }

        [DataMember]
        public decimal InterstateRate
        {
            get { return interstateRate; }
            set { interstateRate = value; }
        }

        [DataMember]
        public decimal WholesaleRate
        {
            get { return wholesaleRate; }
            set { wholesaleRate = value; }
        }

        [DataMember]
        public decimal MRP
        {
            get { return mrp; }
            set { mrp = value; }
        }

        [DataMember]
        public decimal GrossValue
        {
            get { return grossValue; }
            set { grossValue = value; }
        }

        [DataMember]
        public decimal NetValue
        {
            get { return netValue; }
            set { netValue = value; }
        }

        [DataMember]
        public decimal TaxValue
        {
            get { return taxValue; }
            set { taxValue = value; }
        }

        [DataMember]
        public string Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }

        [DataMember]
        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        [DataMember]
        public decimal OldQuantity
        {
            get { return oldQuantity; }
            set { oldQuantity = value; }
        }
    }


    [DataContract]
    public class CPurchaseReturnReportSummary
    {
        string billNo;
        DateTime? billDateTime = new DateTime();
        string supplier;
        string supplierAddress;
        string narration;
        decimal? advance;
        decimal? expense;
        decimal? discount;
        decimal? billAmount;
        string financialCode;

        [DataMember]
        public string BillNo
        {
            get { return billNo; }
            set { billNo = value; }
        }

        [DataMember]
        public DateTime? BillDateTime
        {
            get { return billDateTime; }
            set { billDateTime = value; }
        }

        [DataMember]
        public string Supplier
        {
            get { return supplier; }
            set { supplier = value; }
        }

        [DataMember]
        public string SupplierAddress
        {
            get { return supplierAddress; }
            set { supplierAddress = value; }
        }

        [DataMember]
        public string Narration
        {
            get { return narration; }
            set { narration = value; }
        }

        [DataMember]
        public decimal? Advance
        {
            get { return advance; }
            set { advance = value; }
        }

        [DataMember]
        public decimal? Expense
        {
            get { return expense; }
            set { expense = value; }
        }

        [DataMember]
        public decimal? Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        [DataMember]
        public decimal? BillAmount
        {
            get { return billAmount; }
            set { billAmount = value; }
        }

        [DataMember]
        public string FinancialCode
        {
            get { return financialCode; }
            set { financialCode = value; }
        }
    }

    [DataContract]
    public class CPurchaseReturnReportDetailed
    {
        string billNo;
        DateTime? billDateTime = new DateTime();
        string supplier;
        string supplierAddress;
        string narration;
        decimal? advance;
        decimal? expense;
        decimal? discount;
        string financialCode;

        int? serialNo;
        string product;
        string purchaseUnit;
        decimal? quantity;
        decimal? tax;
        decimal? grossValue;
        decimal? netValue;
        decimal? taxValue;
        decimal? productDiscount;
        decimal? purchaseRate;
        decimal? interstateRate;
        decimal? wholesaleRate;
        decimal? mrp;
        decimal? total;

        [DataMember]
        public string BillNo
        {
            get { return billNo; }
            set { billNo = value; }
        }

        [DataMember]
        public DateTime? BillDateTime
        {
            get { return billDateTime; }
            set { billDateTime = value; }
        }

        [DataMember]
        public string Supplier
        {
            get { return supplier; }
            set { supplier = value; }
        }

        [DataMember]
        public string SupplierAddress
        {
            get { return supplierAddress; }
            set { supplierAddress = value; }
        }

        [DataMember]
        public string Narration
        {
            get { return narration; }
            set { narration = value; }
        }

        [DataMember]
        public decimal? Advance
        {
            get { return advance; }
            set { advance = value; }
        }

        [DataMember]
        public decimal? Expense
        {
            get { return expense; }
            set { expense = value; }
        }

        [DataMember]
        public decimal? Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        [DataMember]
        public string FinancialCode
        {
            get { return financialCode; }
            set { financialCode = value; }
        }

        [DataMember]
        public int? SerialNo
        {
            get { return serialNo; }
            set { serialNo = value; }
        }

        [DataMember]
        public string Product
        {
            get { return product; }
            set { product = value; }
        }

        [DataMember]
        public string PurchaseUnit
        {
            get { return purchaseUnit; }
            set { purchaseUnit = value; }
        }

        [DataMember]
        public decimal? Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        [DataMember]
        public decimal? Tax
        {
            get { return tax; }
            set { tax = value; }
        }

        [DataMember]
        public decimal? ProductDiscount
        {
            get { return productDiscount; }
            set { productDiscount = value; }
        }

        [DataMember]
        public decimal? PurchaseRate
        {
            get { return purchaseRate; }
            set { purchaseRate = value; }
        }

        [DataMember]
        public decimal? InterstateRate
        {
            get { return interstateRate; }
            set { interstateRate = value; }
        }

        [DataMember]
        public decimal? WholesaleRate
        {
            get { return wholesaleRate; }
            set { wholesaleRate = value; }
        }

        [DataMember]
        public decimal? MRP
        {
            get { return mrp; }
            set { mrp = value; }
        }

        [DataMember]
        public decimal? GrossValue
        {
            get { return grossValue; }
            set { grossValue = value; }
        }

        [DataMember]
        public decimal? NetValue
        {
            get { return netValue; }
            set { netValue = value; }
        }

        [DataMember]
        public decimal? TaxValue
        {
            get { return taxValue; }
            set { taxValue = value; }
        }

        [DataMember]
        public decimal? Total
        {
            get { return total; }
            set { total = value; }
        }
    }
}
