using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PaymentManager : IPaymentService
    {

        IPaymentDal _paymentDal;

        public PaymentManager(IPaymentDal paymentDal)
        {
            _paymentDal = paymentDal;
        }
        public IDataResult<Payment> GetByOrderId(int orderId)
        {
            return new SuccessDataResult<Payment>(_paymentDal.Get(p => p.OrderId == orderId));
        }
    }
}
