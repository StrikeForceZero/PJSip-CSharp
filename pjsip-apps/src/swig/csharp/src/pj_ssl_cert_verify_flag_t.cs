//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace PJSIP {

public enum pj_ssl_cert_verify_flag_t {
  PJ_SSL_CERT_ESUCCESS = 0,
  PJ_SSL_CERT_EISSUER_NOT_FOUND = 1 << 0,
  PJ_SSL_CERT_EUNTRUSTED = 1 << 1,
  PJ_SSL_CERT_EVALIDITY_PERIOD = 1 << 2,
  PJ_SSL_CERT_EINVALID_FORMAT = 1 << 3,
  PJ_SSL_CERT_EINVALID_PURPOSE = 1 << 4,
  PJ_SSL_CERT_EISSUER_MISMATCH = 1 << 5,
  PJ_SSL_CERT_ECRL_FAILURE = 1 << 6,
  PJ_SSL_CERT_EREVOKED = 1 << 7,
  PJ_SSL_CERT_ECHAIN_TOO_LONG = 1 << 8,
  PJ_SSL_CERT_EIDENTITY_NOT_MATCH = 1 << 30,
  PJ_SSL_CERT_EUNKNOWN = 1 << 31
}

}
