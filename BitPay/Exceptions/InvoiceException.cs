﻿using System;

namespace BitPayAPI.Exceptions {
    public class InvoiceException : BitPayException {
        private readonly string _bitpayCode = "BITPAY-INVOICE-GENERIC";
        private const string BitPayMessage = "An unexpected error occured while trying to manage the invoice";

        public InvoiceException() : base(BitPayMessage) {
            BitpayCode = _bitpayCode;
        }

        public InvoiceException(Exception ex) : base(BitPayMessage, ex) {
            BitpayCode = _bitpayCode;
        }

        public InvoiceException(string bitpayCode, string message) : base(bitpayCode, message) {
        }

        public InvoiceException(string bitpayCode, string message, Exception cause) : base(bitpayCode, message, cause) {
        }
    }
}
