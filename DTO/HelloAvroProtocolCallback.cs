// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace HelloAvro.DTO
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	/// <summary>
	/// Hello Avro examples here\r\n  See http://avro.apache.org/docs/1.7.5/idl.html for more info on\r\n  how you can express your data in the IDL syntax
	/// </summary>
	public abstract class HelloAvroProtocolCallback : HelloAvroProtocol
	{
		public abstract void TransformName(HelloAvro.DTO.EmployeeDTO employee, Avro.IO.ICallback<System.String> callback);
		public abstract void hello(string name, Avro.IO.ICallback<System.String> callback);
		public abstract void add(int arg1, int arg2, Avro.IO.ICallback<System.Int32> callback);
		public abstract void divide(int arg1, int arg2, Avro.IO.ICallback<System.Int32> callback);
	}
}
