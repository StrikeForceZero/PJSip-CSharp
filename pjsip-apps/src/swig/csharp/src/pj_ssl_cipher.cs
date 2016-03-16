//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.8
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pjsua2 {

public enum pj_ssl_cipher {
  PJ_TLS_UNKNOWN_CIPHER = -1,
  PJ_TLS_NULL_WITH_NULL_NULL = 0x00000000,
  PJ_TLS_RSA_WITH_NULL_MD5 = 0x00000001,
  PJ_TLS_RSA_WITH_NULL_SHA = 0x00000002,
  PJ_TLS_RSA_WITH_NULL_SHA256 = 0x0000003B,
  PJ_TLS_RSA_WITH_RC4_128_MD5 = 0x00000004,
  PJ_TLS_RSA_WITH_RC4_128_SHA = 0x00000005,
  PJ_TLS_RSA_WITH_3DES_EDE_CBC_SHA = 0x0000000A,
  PJ_TLS_RSA_WITH_AES_128_CBC_SHA = 0x0000002F,
  PJ_TLS_RSA_WITH_AES_256_CBC_SHA = 0x00000035,
  PJ_TLS_RSA_WITH_AES_128_CBC_SHA256 = 0x0000003C,
  PJ_TLS_RSA_WITH_AES_256_CBC_SHA256 = 0x0000003D,
  PJ_TLS_DH_DSS_WITH_3DES_EDE_CBC_SHA = 0x0000000D,
  PJ_TLS_DH_RSA_WITH_3DES_EDE_CBC_SHA = 0x00000010,
  PJ_TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA = 0x00000013,
  PJ_TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA = 0x00000016,
  PJ_TLS_DH_DSS_WITH_AES_128_CBC_SHA = 0x00000030,
  PJ_TLS_DH_RSA_WITH_AES_128_CBC_SHA = 0x00000031,
  PJ_TLS_DHE_DSS_WITH_AES_128_CBC_SHA = 0x00000032,
  PJ_TLS_DHE_RSA_WITH_AES_128_CBC_SHA = 0x00000033,
  PJ_TLS_DH_DSS_WITH_AES_256_CBC_SHA = 0x00000036,
  PJ_TLS_DH_RSA_WITH_AES_256_CBC_SHA = 0x00000037,
  PJ_TLS_DHE_DSS_WITH_AES_256_CBC_SHA = 0x00000038,
  PJ_TLS_DHE_RSA_WITH_AES_256_CBC_SHA = 0x00000039,
  PJ_TLS_DH_DSS_WITH_AES_128_CBC_SHA256 = 0x0000003E,
  PJ_TLS_DH_RSA_WITH_AES_128_CBC_SHA256 = 0x0000003F,
  PJ_TLS_DHE_DSS_WITH_AES_128_CBC_SHA256 = 0x00000040,
  PJ_TLS_DHE_RSA_WITH_AES_128_CBC_SHA256 = 0x00000067,
  PJ_TLS_DH_DSS_WITH_AES_256_CBC_SHA256 = 0x00000068,
  PJ_TLS_DH_RSA_WITH_AES_256_CBC_SHA256 = 0x00000069,
  PJ_TLS_DHE_DSS_WITH_AES_256_CBC_SHA256 = 0x0000006A,
  PJ_TLS_DHE_RSA_WITH_AES_256_CBC_SHA256 = 0x0000006B,
  PJ_TLS_DH_anon_WITH_RC4_128_MD5 = 0x00000018,
  PJ_TLS_DH_anon_WITH_3DES_EDE_CBC_SHA = 0x0000001B,
  PJ_TLS_DH_anon_WITH_AES_128_CBC_SHA = 0x00000034,
  PJ_TLS_DH_anon_WITH_AES_256_CBC_SHA = 0x0000003A,
  PJ_TLS_DH_anon_WITH_AES_128_CBC_SHA256 = 0x0000006C,
  PJ_TLS_DH_anon_WITH_AES_256_CBC_SHA256 = 0x0000006D,
  PJ_TLS_RSA_EXPORT_WITH_RC4_40_MD5 = 0x00000003,
  PJ_TLS_RSA_EXPORT_WITH_RC2_CBC_40_MD5 = 0x00000006,
  PJ_TLS_RSA_WITH_IDEA_CBC_SHA = 0x00000007,
  PJ_TLS_RSA_EXPORT_WITH_DES40_CBC_SHA = 0x00000008,
  PJ_TLS_RSA_WITH_DES_CBC_SHA = 0x00000009,
  PJ_TLS_DH_DSS_EXPORT_WITH_DES40_CBC_SHA = 0x0000000B,
  PJ_TLS_DH_DSS_WITH_DES_CBC_SHA = 0x0000000C,
  PJ_TLS_DH_RSA_EXPORT_WITH_DES40_CBC_SHA = 0x0000000E,
  PJ_TLS_DH_RSA_WITH_DES_CBC_SHA = 0x0000000F,
  PJ_TLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA = 0x00000011,
  PJ_TLS_DHE_DSS_WITH_DES_CBC_SHA = 0x00000012,
  PJ_TLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA = 0x00000014,
  PJ_TLS_DHE_RSA_WITH_DES_CBC_SHA = 0x00000015,
  PJ_TLS_DH_anon_EXPORT_WITH_RC4_40_MD5 = 0x00000017,
  PJ_TLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA = 0x00000019,
  PJ_TLS_DH_anon_WITH_DES_CBC_SHA = 0x0000001A,
  PJ_SSL_FORTEZZA_KEA_WITH_NULL_SHA = 0x0000001C,
  PJ_SSL_FORTEZZA_KEA_WITH_FORTEZZA_CBC_SHA = 0x0000001D,
  PJ_SSL_FORTEZZA_KEA_WITH_RC4_128_SHA = 0x0000001E,
  PJ_SSL_CK_RC4_128_WITH_MD5 = 0x00010080,
  PJ_SSL_CK_RC4_128_EXPORT40_WITH_MD5 = 0x00020080,
  PJ_SSL_CK_RC2_128_CBC_WITH_MD5 = 0x00030080,
  PJ_SSL_CK_RC2_128_CBC_EXPORT40_WITH_MD5 = 0x00040080,
  PJ_SSL_CK_IDEA_128_CBC_WITH_MD5 = 0x00050080,
  PJ_SSL_CK_DES_64_CBC_WITH_MD5 = 0x00060040,
  PJ_SSL_CK_DES_192_EDE3_CBC_WITH_MD5 = 0x000700C0
}

}
