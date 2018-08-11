using System;
using System.Numerics;
using System.Runtime.CompilerServices;
namespace BlueDove.BenchLab
{
	public sealed class NumericOperator_sbyte : NumericOperator<sbyte>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override sbyte Add( sbyte left, sbyte right)
			=> (sbyte)( left + right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override sbyte Subtract( sbyte left, sbyte right)
			=> (sbyte)( left - right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override sbyte Multiply( sbyte left, sbyte right)
			=> (sbyte)( left * right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override sbyte Divide( sbyte left, sbyte right)
			=> (sbyte)( left / right);
		public sealed override sbyte UnaryPlus( sbyte value)
			=> (sbyte)+value;
		public sealed override sbyte UnaryMinus( sbyte value)
			=> (sbyte)-value;
		//public sealed override sbyte Zero{ get; } = 0;
		//public sealed override sbyte One{ get; } = 1;
	}
	public sealed class NumericOperator_byte : NumericOperator<byte>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override byte Add( byte left, byte right)
			=> (byte)( left + right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override byte Subtract( byte left, byte right)
			=> (byte)( left - right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override byte Multiply( byte left, byte right)
			=> (byte)( left * right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override byte Divide( byte left, byte right)
			=> (byte)( left / right);
		public sealed override byte UnaryPlus( byte value)
			=> (byte)+value;
		public sealed override byte UnaryMinus( byte value)
			=> (byte)-value;
		//public sealed override byte Zero{ get; } = 0;
		//public sealed override byte One{ get; } = 1;
	}
	public sealed class NumericOperator_short : NumericOperator<short>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override short Add( short left, short right)
			=> (short)( left + right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override short Subtract( short left, short right)
			=> (short)( left - right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override short Multiply( short left, short right)
			=> (short)( left * right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override short Divide( short left, short right)
			=> (short)( left / right);
		public sealed override short UnaryPlus( short value)
			=> (short)+value;
		public sealed override short UnaryMinus( short value)
			=> (short)-value;
		//public sealed override short Zero{ get; } = 0;
		//public sealed override short One{ get; } = 1;
	}
	public sealed class NumericOperator_ushort : NumericOperator<ushort>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override ushort Add( ushort left, ushort right)
			=> (ushort)( left + right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override ushort Subtract( ushort left, ushort right)
			=> (ushort)( left - right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override ushort Multiply( ushort left, ushort right)
			=> (ushort)( left * right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override ushort Divide( ushort left, ushort right)
			=> (ushort)( left / right);
		public sealed override ushort UnaryPlus( ushort value)
			=> (ushort)+value;
		public sealed override ushort UnaryMinus( ushort value)
			=> (ushort)-value;
		//public sealed override ushort Zero{ get; } = 0;
		//public sealed override ushort One{ get; } = 1;
	}
	public sealed class NumericOperator_int : NumericOperator<int>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override int Add( int left, int right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override int Subtract( int left, int right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override int Multiply( int left, int right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override int Divide( int left, int right)
			=>  left / right;
		public sealed override int UnaryPlus( int value)
			=> +value;
		public sealed override int UnaryMinus( int value)
			=> -value;
		//public sealed override int Zero{ get; } = 0;
		//public sealed override int One{ get; } = 1;
	}
	public sealed class NumericOperator_uint : NumericOperator<uint>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override uint Add( uint left, uint right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override uint Subtract( uint left, uint right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override uint Multiply( uint left, uint right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override uint Divide( uint left, uint right)
			=>  left / right;
		public sealed override uint UnaryPlus( uint value)
			=> +value;
		public sealed override uint UnaryMinus( uint value)
			=> throw new NotSupportedException();
		//public sealed override uint Zero{ get; } = 0;
		//public sealed override uint One{ get; } = 1;
	}
	public sealed class NumericOperator_long : NumericOperator<long>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override long Add( long left, long right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override long Subtract( long left, long right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override long Multiply( long left, long right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override long Divide( long left, long right)
			=>  left / right;
		public sealed override long UnaryPlus( long value)
			=> +value;
		public sealed override long UnaryMinus( long value)
			=> -value;
		//public sealed override long Zero{ get; } = 0;
		//public sealed override long One{ get; } = 1;
	}
	public sealed class NumericOperator_ulong : NumericOperator<ulong>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override ulong Add( ulong left, ulong right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override ulong Subtract( ulong left, ulong right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override ulong Multiply( ulong left, ulong right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override ulong Divide( ulong left, ulong right)
			=>  left / right;
		public sealed override ulong UnaryPlus( ulong value)
			=> +value;
		public sealed override ulong UnaryMinus( ulong value)
			=> throw new NotSupportedException();
		//public sealed override ulong Zero{ get; } = 0;
		//public sealed override ulong One{ get; } = 1;
	}
	public sealed class NumericOperator_float : NumericOperator<float>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override float Add( float left, float right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override float Subtract( float left, float right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override float Multiply( float left, float right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override float Divide( float left, float right)
			=>  left / right;
		public sealed override float UnaryPlus( float value)
			=> +value;
		public sealed override float UnaryMinus( float value)
			=> -value;
		//public sealed override float Zero{ get; } = 0;
		//public sealed override float One{ get; } = 1;
	}
	public sealed class NumericOperator_double : NumericOperator<double>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override double Add( double left, double right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override double Subtract( double left, double right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override double Multiply( double left, double right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override double Divide( double left, double right)
			=>  left / right;
		public sealed override double UnaryPlus( double value)
			=> +value;
		public sealed override double UnaryMinus( double value)
			=> -value;
		//public sealed override double Zero{ get; } = 0;
		//public sealed override double One{ get; } = 1;
	}
	public sealed class NumericOperator_decimal : NumericOperator<decimal>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override decimal Add( decimal left, decimal right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override decimal Subtract( decimal left, decimal right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override decimal Multiply( decimal left, decimal right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override decimal Divide( decimal left, decimal right)
			=>  left / right;
		public sealed override decimal UnaryPlus( decimal value)
			=> +value;
		public sealed override decimal UnaryMinus( decimal value)
			=> -value;
		//public sealed override decimal Zero{ get; } = 0;
		//public sealed override decimal One{ get; } = 1;
	}
	public sealed class NumericOperator_Complex : NumericOperator<Complex>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override Complex Add( Complex left, Complex right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override Complex Subtract( Complex left, Complex right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override Complex Multiply( Complex left, Complex right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override Complex Divide( Complex left, Complex right)
			=>  left / right;
		public sealed override Complex UnaryPlus( Complex value)
			=> throw new NotSupportedException();
		public sealed override Complex UnaryMinus( Complex value)
			=> -value;
		//public sealed override Complex Zero{ get; } = 0;
		//public sealed override Complex One{ get; } = 1;
	}
	public sealed class NumericOperator_BigInteger : NumericOperator<BigInteger>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override BigInteger Add( BigInteger left, BigInteger right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override BigInteger Subtract( BigInteger left, BigInteger right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override BigInteger Multiply( BigInteger left, BigInteger right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override BigInteger Divide( BigInteger left, BigInteger right)
			=>  left / right;
		public sealed override BigInteger UnaryPlus( BigInteger value)
			=> +value;
		public sealed override BigInteger UnaryMinus( BigInteger value)
			=> -value;
		//public sealed override BigInteger Zero{ get; } = 0;
		//public sealed override BigInteger One{ get; } = 1;
	}
	public struct NumericOperatorS_sbyte : INumericOperator<sbyte>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  sbyte Add( sbyte left, sbyte right)
			=> (sbyte)( left + right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  sbyte Subtract( sbyte left, sbyte right)
			=> (sbyte)( left - right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  sbyte Multiply( sbyte left, sbyte right)
			=> (sbyte)( left * right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  sbyte Divide( sbyte left, sbyte right)
			=> (sbyte)( left / right);
		public  sbyte UnaryPlus( sbyte value)
			=> (sbyte)+value;
		public  sbyte UnaryMinus( sbyte value)
			=> (sbyte)-value;
		//public  sbyte Zero{ get; } = 0;
		//public  sbyte One{ get; } = 1;
	}
	public struct NumericOperatorS_byte : INumericOperator<byte>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  byte Add( byte left, byte right)
			=> (byte)( left + right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  byte Subtract( byte left, byte right)
			=> (byte)( left - right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  byte Multiply( byte left, byte right)
			=> (byte)( left * right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  byte Divide( byte left, byte right)
			=> (byte)( left / right);
		public  byte UnaryPlus( byte value)
			=> (byte)+value;
		public  byte UnaryMinus( byte value)
			=> (byte)-value;
		//public  byte Zero{ get; } = 0;
		//public  byte One{ get; } = 1;
	}
	public struct NumericOperatorS_short : INumericOperator<short>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  short Add( short left, short right)
			=> (short)( left + right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  short Subtract( short left, short right)
			=> (short)( left - right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  short Multiply( short left, short right)
			=> (short)( left * right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  short Divide( short left, short right)
			=> (short)( left / right);
		public  short UnaryPlus( short value)
			=> (short)+value;
		public  short UnaryMinus( short value)
			=> (short)-value;
		//public  short Zero{ get; } = 0;
		//public  short One{ get; } = 1;
	}
	public struct NumericOperatorS_ushort : INumericOperator<ushort>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  ushort Add( ushort left, ushort right)
			=> (ushort)( left + right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  ushort Subtract( ushort left, ushort right)
			=> (ushort)( left - right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  ushort Multiply( ushort left, ushort right)
			=> (ushort)( left * right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  ushort Divide( ushort left, ushort right)
			=> (ushort)( left / right);
		public  ushort UnaryPlus( ushort value)
			=> (ushort)+value;
		public  ushort UnaryMinus( ushort value)
			=> (ushort)-value;
		//public  ushort Zero{ get; } = 0;
		//public  ushort One{ get; } = 1;
	}
	public struct NumericOperatorS_int : INumericOperator<int>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  int Add( int left, int right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  int Subtract( int left, int right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  int Multiply( int left, int right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  int Divide( int left, int right)
			=>  left / right;
		public  int UnaryPlus( int value)
			=> +value;
		public  int UnaryMinus( int value)
			=> -value;
		//public  int Zero{ get; } = 0;
		//public  int One{ get; } = 1;
	}
	public struct NumericOperatorS_uint : INumericOperator<uint>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  uint Add( uint left, uint right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  uint Subtract( uint left, uint right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  uint Multiply( uint left, uint right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  uint Divide( uint left, uint right)
			=>  left / right;
		public  uint UnaryPlus( uint value)
			=> +value;
		public  uint UnaryMinus( uint value)
			=> throw new NotSupportedException();
		//public  uint Zero{ get; } = 0;
		//public  uint One{ get; } = 1;
	}
	public struct NumericOperatorS_long : INumericOperator<long>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  long Add( long left, long right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  long Subtract( long left, long right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  long Multiply( long left, long right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  long Divide( long left, long right)
			=>  left / right;
		public  long UnaryPlus( long value)
			=> +value;
		public  long UnaryMinus( long value)
			=> -value;
		//public  long Zero{ get; } = 0;
		//public  long One{ get; } = 1;
	}
	public struct NumericOperatorS_ulong : INumericOperator<ulong>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  ulong Add( ulong left, ulong right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  ulong Subtract( ulong left, ulong right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  ulong Multiply( ulong left, ulong right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  ulong Divide( ulong left, ulong right)
			=>  left / right;
		public  ulong UnaryPlus( ulong value)
			=> +value;
		public  ulong UnaryMinus( ulong value)
			=> throw new NotSupportedException();
		//public  ulong Zero{ get; } = 0;
		//public  ulong One{ get; } = 1;
	}
	public struct NumericOperatorS_float : INumericOperator<float>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  float Add( float left, float right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  float Subtract( float left, float right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  float Multiply( float left, float right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  float Divide( float left, float right)
			=>  left / right;
		public  float UnaryPlus( float value)
			=> +value;
		public  float UnaryMinus( float value)
			=> -value;
		//public  float Zero{ get; } = 0;
		//public  float One{ get; } = 1;
	}
	public struct NumericOperatorS_double : INumericOperator<double>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  double Add( double left, double right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  double Subtract( double left, double right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  double Multiply( double left, double right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  double Divide( double left, double right)
			=>  left / right;
		public  double UnaryPlus( double value)
			=> +value;
		public  double UnaryMinus( double value)
			=> -value;
		//public  double Zero{ get; } = 0;
		//public  double One{ get; } = 1;
	}
	public struct NumericOperatorS_decimal : INumericOperator<decimal>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  decimal Add( decimal left, decimal right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  decimal Subtract( decimal left, decimal right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  decimal Multiply( decimal left, decimal right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  decimal Divide( decimal left, decimal right)
			=>  left / right;
		public  decimal UnaryPlus( decimal value)
			=> +value;
		public  decimal UnaryMinus( decimal value)
			=> -value;
		//public  decimal Zero{ get; } = 0;
		//public  decimal One{ get; } = 1;
	}
	public struct NumericOperatorS_Complex : INumericOperator<Complex>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  Complex Add( Complex left, Complex right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  Complex Subtract( Complex left, Complex right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  Complex Multiply( Complex left, Complex right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  Complex Divide( Complex left, Complex right)
			=>  left / right;
		public  Complex UnaryPlus( Complex value)
			=> throw new NotSupportedException();
		public  Complex UnaryMinus( Complex value)
			=> -value;
		//public  Complex Zero{ get; } = 0;
		//public  Complex One{ get; } = 1;
	}
	public struct NumericOperatorS_BigInteger : INumericOperator<BigInteger>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  BigInteger Add( BigInteger left, BigInteger right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  BigInteger Subtract( BigInteger left, BigInteger right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  BigInteger Multiply( BigInteger left, BigInteger right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  BigInteger Divide( BigInteger left, BigInteger right)
			=>  left / right;
		public  BigInteger UnaryPlus( BigInteger value)
			=> +value;
		public  BigInteger UnaryMinus( BigInteger value)
			=> -value;
		//public  BigInteger Zero{ get; } = 0;
		//public  BigInteger One{ get; } = 1;
	}
	public sealed class InNumericOperator_sbyte : InNumericOperator<sbyte>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override sbyte Add(in sbyte left,in sbyte right)
			=> (sbyte)( left + right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override sbyte Subtract(in sbyte left,in sbyte right)
			=> (sbyte)( left - right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override sbyte Multiply(in sbyte left,in sbyte right)
			=> (sbyte)( left * right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override sbyte Divide(in sbyte left,in sbyte right)
			=> (sbyte)( left / right);
		public sealed override sbyte UnaryPlus(in sbyte value)
			=> (sbyte)+value;
		public sealed override sbyte UnaryMinus(in sbyte value)
			=> (sbyte)-value;
		//public sealed override sbyte Zero{ get; } = 0;
		//public sealed override sbyte One{ get; } = 1;
	}
	public sealed class InNumericOperator_byte : InNumericOperator<byte>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override byte Add(in byte left,in byte right)
			=> (byte)( left + right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override byte Subtract(in byte left,in byte right)
			=> (byte)( left - right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override byte Multiply(in byte left,in byte right)
			=> (byte)( left * right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override byte Divide(in byte left,in byte right)
			=> (byte)( left / right);
		public sealed override byte UnaryPlus(in byte value)
			=> (byte)+value;
		public sealed override byte UnaryMinus(in byte value)
			=> (byte)-value;
		//public sealed override byte Zero{ get; } = 0;
		//public sealed override byte One{ get; } = 1;
	}
	public sealed class InNumericOperator_short : InNumericOperator<short>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override short Add(in short left,in short right)
			=> (short)( left + right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override short Subtract(in short left,in short right)
			=> (short)( left - right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override short Multiply(in short left,in short right)
			=> (short)( left * right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override short Divide(in short left,in short right)
			=> (short)( left / right);
		public sealed override short UnaryPlus(in short value)
			=> (short)+value;
		public sealed override short UnaryMinus(in short value)
			=> (short)-value;
		//public sealed override short Zero{ get; } = 0;
		//public sealed override short One{ get; } = 1;
	}
	public sealed class InNumericOperator_ushort : InNumericOperator<ushort>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override ushort Add(in ushort left,in ushort right)
			=> (ushort)( left + right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override ushort Subtract(in ushort left,in ushort right)
			=> (ushort)( left - right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override ushort Multiply(in ushort left,in ushort right)
			=> (ushort)( left * right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override ushort Divide(in ushort left,in ushort right)
			=> (ushort)( left / right);
		public sealed override ushort UnaryPlus(in ushort value)
			=> (ushort)+value;
		public sealed override ushort UnaryMinus(in ushort value)
			=> (ushort)-value;
		//public sealed override ushort Zero{ get; } = 0;
		//public sealed override ushort One{ get; } = 1;
	}
	public sealed class InNumericOperator_int : InNumericOperator<int>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override int Add(in int left,in int right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override int Subtract(in int left,in int right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override int Multiply(in int left,in int right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override int Divide(in int left,in int right)
			=>  left / right;
		public sealed override int UnaryPlus(in int value)
			=> +value;
		public sealed override int UnaryMinus(in int value)
			=> -value;
		//public sealed override int Zero{ get; } = 0;
		//public sealed override int One{ get; } = 1;
	}
	public sealed class InNumericOperator_uint : InNumericOperator<uint>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override uint Add(in uint left,in uint right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override uint Subtract(in uint left,in uint right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override uint Multiply(in uint left,in uint right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override uint Divide(in uint left,in uint right)
			=>  left / right;
		public sealed override uint UnaryPlus(in uint value)
			=> +value;
		public sealed override uint UnaryMinus(in uint value)
			=> throw new NotSupportedException();
		//public sealed override uint Zero{ get; } = 0;
		//public sealed override uint One{ get; } = 1;
	}
	public sealed class InNumericOperator_long : InNumericOperator<long>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override long Add(in long left,in long right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override long Subtract(in long left,in long right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override long Multiply(in long left,in long right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override long Divide(in long left,in long right)
			=>  left / right;
		public sealed override long UnaryPlus(in long value)
			=> +value;
		public sealed override long UnaryMinus(in long value)
			=> -value;
		//public sealed override long Zero{ get; } = 0;
		//public sealed override long One{ get; } = 1;
	}
	public sealed class InNumericOperator_ulong : InNumericOperator<ulong>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override ulong Add(in ulong left,in ulong right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override ulong Subtract(in ulong left,in ulong right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override ulong Multiply(in ulong left,in ulong right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override ulong Divide(in ulong left,in ulong right)
			=>  left / right;
		public sealed override ulong UnaryPlus(in ulong value)
			=> +value;
		public sealed override ulong UnaryMinus(in ulong value)
			=> throw new NotSupportedException();
		//public sealed override ulong Zero{ get; } = 0;
		//public sealed override ulong One{ get; } = 1;
	}
	public sealed class InNumericOperator_float : InNumericOperator<float>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override float Add(in float left,in float right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override float Subtract(in float left,in float right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override float Multiply(in float left,in float right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override float Divide(in float left,in float right)
			=>  left / right;
		public sealed override float UnaryPlus(in float value)
			=> +value;
		public sealed override float UnaryMinus(in float value)
			=> -value;
		//public sealed override float Zero{ get; } = 0;
		//public sealed override float One{ get; } = 1;
	}
	public sealed class InNumericOperator_double : InNumericOperator<double>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override double Add(in double left,in double right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override double Subtract(in double left,in double right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override double Multiply(in double left,in double right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override double Divide(in double left,in double right)
			=>  left / right;
		public sealed override double UnaryPlus(in double value)
			=> +value;
		public sealed override double UnaryMinus(in double value)
			=> -value;
		//public sealed override double Zero{ get; } = 0;
		//public sealed override double One{ get; } = 1;
	}
	public sealed class InNumericOperator_decimal : InNumericOperator<decimal>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override decimal Add(in decimal left,in decimal right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override decimal Subtract(in decimal left,in decimal right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override decimal Multiply(in decimal left,in decimal right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override decimal Divide(in decimal left,in decimal right)
			=>  left / right;
		public sealed override decimal UnaryPlus(in decimal value)
			=> +value;
		public sealed override decimal UnaryMinus(in decimal value)
			=> -value;
		//public sealed override decimal Zero{ get; } = 0;
		//public sealed override decimal One{ get; } = 1;
	}
	public sealed class InNumericOperator_Complex : InNumericOperator<Complex>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override Complex Add(in Complex left,in Complex right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override Complex Subtract(in Complex left,in Complex right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override Complex Multiply(in Complex left,in Complex right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override Complex Divide(in Complex left,in Complex right)
			=>  left / right;
		public sealed override Complex UnaryPlus(in Complex value)
			=> throw new NotSupportedException();
		public sealed override Complex UnaryMinus(in Complex value)
			=> -value;
		//public sealed override Complex Zero{ get; } = 0;
		//public sealed override Complex One{ get; } = 1;
	}
	public sealed class InNumericOperator_BigInteger : InNumericOperator<BigInteger>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override BigInteger Add(in BigInteger left,in BigInteger right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override BigInteger Subtract(in BigInteger left,in BigInteger right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override BigInteger Multiply(in BigInteger left,in BigInteger right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override BigInteger Divide(in BigInteger left,in BigInteger right)
			=>  left / right;
		public sealed override BigInteger UnaryPlus(in BigInteger value)
			=> +value;
		public sealed override BigInteger UnaryMinus(in BigInteger value)
			=> -value;
		//public sealed override BigInteger Zero{ get; } = 0;
		//public sealed override BigInteger One{ get; } = 1;
	}
	public struct InNumericOperatorS_sbyte : IInNumericOperator<sbyte>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  sbyte Add(in sbyte left,in sbyte right)
			=> (sbyte)( left + right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  sbyte Subtract(in sbyte left,in sbyte right)
			=> (sbyte)( left - right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  sbyte Multiply(in sbyte left,in sbyte right)
			=> (sbyte)( left * right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  sbyte Divide(in sbyte left,in sbyte right)
			=> (sbyte)( left / right);
		public  sbyte UnaryPlus(in sbyte value)
			=> (sbyte)+value;
		public  sbyte UnaryMinus(in sbyte value)
			=> (sbyte)-value;
		//public  sbyte Zero{ get; } = 0;
		//public  sbyte One{ get; } = 1;
	}
	public struct InNumericOperatorS_byte : IInNumericOperator<byte>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  byte Add(in byte left,in byte right)
			=> (byte)( left + right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  byte Subtract(in byte left,in byte right)
			=> (byte)( left - right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  byte Multiply(in byte left,in byte right)
			=> (byte)( left * right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  byte Divide(in byte left,in byte right)
			=> (byte)( left / right);
		public  byte UnaryPlus(in byte value)
			=> (byte)+value;
		public  byte UnaryMinus(in byte value)
			=> (byte)-value;
		//public  byte Zero{ get; } = 0;
		//public  byte One{ get; } = 1;
	}
	public struct InNumericOperatorS_short : IInNumericOperator<short>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  short Add(in short left,in short right)
			=> (short)( left + right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  short Subtract(in short left,in short right)
			=> (short)( left - right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  short Multiply(in short left,in short right)
			=> (short)( left * right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  short Divide(in short left,in short right)
			=> (short)( left / right);
		public  short UnaryPlus(in short value)
			=> (short)+value;
		public  short UnaryMinus(in short value)
			=> (short)-value;
		//public  short Zero{ get; } = 0;
		//public  short One{ get; } = 1;
	}
	public struct InNumericOperatorS_ushort : IInNumericOperator<ushort>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  ushort Add(in ushort left,in ushort right)
			=> (ushort)( left + right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  ushort Subtract(in ushort left,in ushort right)
			=> (ushort)( left - right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  ushort Multiply(in ushort left,in ushort right)
			=> (ushort)( left * right);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  ushort Divide(in ushort left,in ushort right)
			=> (ushort)( left / right);
		public  ushort UnaryPlus(in ushort value)
			=> (ushort)+value;
		public  ushort UnaryMinus(in ushort value)
			=> (ushort)-value;
		//public  ushort Zero{ get; } = 0;
		//public  ushort One{ get; } = 1;
	}
	public struct InNumericOperatorS_int : IInNumericOperator<int>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  int Add(in int left,in int right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  int Subtract(in int left,in int right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  int Multiply(in int left,in int right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  int Divide(in int left,in int right)
			=>  left / right;
		public  int UnaryPlus(in int value)
			=> +value;
		public  int UnaryMinus(in int value)
			=> -value;
		//public  int Zero{ get; } = 0;
		//public  int One{ get; } = 1;
	}
	public struct InNumericOperatorS_uint : IInNumericOperator<uint>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  uint Add(in uint left,in uint right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  uint Subtract(in uint left,in uint right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  uint Multiply(in uint left,in uint right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  uint Divide(in uint left,in uint right)
			=>  left / right;
		public  uint UnaryPlus(in uint value)
			=> +value;
		public  uint UnaryMinus(in uint value)
			=> throw new NotSupportedException();
		//public  uint Zero{ get; } = 0;
		//public  uint One{ get; } = 1;
	}
	public struct InNumericOperatorS_long : IInNumericOperator<long>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  long Add(in long left,in long right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  long Subtract(in long left,in long right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  long Multiply(in long left,in long right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  long Divide(in long left,in long right)
			=>  left / right;
		public  long UnaryPlus(in long value)
			=> +value;
		public  long UnaryMinus(in long value)
			=> -value;
		//public  long Zero{ get; } = 0;
		//public  long One{ get; } = 1;
	}
	public struct InNumericOperatorS_ulong : IInNumericOperator<ulong>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  ulong Add(in ulong left,in ulong right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  ulong Subtract(in ulong left,in ulong right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  ulong Multiply(in ulong left,in ulong right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  ulong Divide(in ulong left,in ulong right)
			=>  left / right;
		public  ulong UnaryPlus(in ulong value)
			=> +value;
		public  ulong UnaryMinus(in ulong value)
			=> throw new NotSupportedException();
		//public  ulong Zero{ get; } = 0;
		//public  ulong One{ get; } = 1;
	}
	public struct InNumericOperatorS_float : IInNumericOperator<float>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  float Add(in float left,in float right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  float Subtract(in float left,in float right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  float Multiply(in float left,in float right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  float Divide(in float left,in float right)
			=>  left / right;
		public  float UnaryPlus(in float value)
			=> +value;
		public  float UnaryMinus(in float value)
			=> -value;
		//public  float Zero{ get; } = 0;
		//public  float One{ get; } = 1;
	}
	public struct InNumericOperatorS_double : IInNumericOperator<double>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  double Add(in double left,in double right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  double Subtract(in double left,in double right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  double Multiply(in double left,in double right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  double Divide(in double left,in double right)
			=>  left / right;
		public  double UnaryPlus(in double value)
			=> +value;
		public  double UnaryMinus(in double value)
			=> -value;
		//public  double Zero{ get; } = 0;
		//public  double One{ get; } = 1;
	}
	public struct InNumericOperatorS_decimal : IInNumericOperator<decimal>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  decimal Add(in decimal left,in decimal right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  decimal Subtract(in decimal left,in decimal right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  decimal Multiply(in decimal left,in decimal right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  decimal Divide(in decimal left,in decimal right)
			=>  left / right;
		public  decimal UnaryPlus(in decimal value)
			=> +value;
		public  decimal UnaryMinus(in decimal value)
			=> -value;
		//public  decimal Zero{ get; } = 0;
		//public  decimal One{ get; } = 1;
	}
	public struct InNumericOperatorS_Complex : IInNumericOperator<Complex>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  Complex Add(in Complex left,in Complex right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  Complex Subtract(in Complex left,in Complex right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  Complex Multiply(in Complex left,in Complex right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  Complex Divide(in Complex left,in Complex right)
			=>  left / right;
		public  Complex UnaryPlus(in Complex value)
			=> throw new NotSupportedException();
		public  Complex UnaryMinus(in Complex value)
			=> -value;
		//public  Complex Zero{ get; } = 0;
		//public  Complex One{ get; } = 1;
	}
	public struct InNumericOperatorS_BigInteger : IInNumericOperator<BigInteger>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  BigInteger Add(in BigInteger left,in BigInteger right)
			=>  left + right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  BigInteger Subtract(in BigInteger left,in BigInteger right)
			=>  left - right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  BigInteger Multiply(in BigInteger left,in BigInteger right)
			=>  left * right;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public  BigInteger Divide(in BigInteger left,in BigInteger right)
			=>  left / right;
		public  BigInteger UnaryPlus(in BigInteger value)
			=> +value;
		public  BigInteger UnaryMinus(in BigInteger value)
			=> -value;
		//public  BigInteger Zero{ get; } = 0;
		//public  BigInteger One{ get; } = 1;
	}
    internal static class NumericOperatorHelper
    {
        public static object CreateDefualtOperator(Type type)
        {
			if(type == typeof(sbyte))
				return new NumericOperator_sbyte();
			else
			if(type == typeof(byte))
				return new NumericOperator_byte();
			else
			if(type == typeof(short))
				return new NumericOperator_short();
			else
			if(type == typeof(ushort))
				return new NumericOperator_ushort();
			else
			if(type == typeof(int))
				return new NumericOperator_int();
			else
			if(type == typeof(uint))
				return new NumericOperator_uint();
			else
			if(type == typeof(long))
				return new NumericOperator_long();
			else
			if(type == typeof(ulong))
				return new NumericOperator_ulong();
			else
			if(type == typeof(float))
				return new NumericOperator_float();
			else
			if(type == typeof(double))
				return new NumericOperator_double();
			else
			if(type == typeof(decimal))
				return new NumericOperator_decimal();
			else
			if(type == typeof(Complex))
				return new NumericOperator_Complex();
			else
			if(type == typeof(BigInteger))
				return new NumericOperator_BigInteger();
			else
				throw new NotSupportedException();
        }

		public static object CreateInDefualtOperator(Type type)
        {
			if(type == typeof(sbyte))
				return new InNumericOperator_sbyte();
			else
			if(type == typeof(byte))
				return new InNumericOperator_byte();
			else
			if(type == typeof(short))
				return new InNumericOperator_short();
			else
			if(type == typeof(ushort))
				return new InNumericOperator_ushort();
			else
			if(type == typeof(int))
				return new InNumericOperator_int();
			else
			if(type == typeof(uint))
				return new InNumericOperator_uint();
			else
			if(type == typeof(long))
				return new InNumericOperator_long();
			else
			if(type == typeof(ulong))
				return new InNumericOperator_ulong();
			else
			if(type == typeof(float))
				return new InNumericOperator_float();
			else
			if(type == typeof(double))
				return new InNumericOperator_double();
			else
			if(type == typeof(decimal))
				return new InNumericOperator_decimal();
			else
			if(type == typeof(Complex))
				return new InNumericOperator_Complex();
			else
			if(type == typeof(BigInteger))
				return new InNumericOperator_BigInteger();
			else
				throw new NotSupportedException();
        }
    }
}