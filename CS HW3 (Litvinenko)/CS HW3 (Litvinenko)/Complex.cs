namespace CS_HW3__Litvinenko_
{
    class Complex
	{
		double _real;
		double _imaginary;

		public double Real
		{
			get { return _real; }
			set { _real = value; }
		}

		public double Iimaginary
		{
			get { return _imaginary; }
			set { _imaginary = value; }
		}


		public Complex()
		{
			_real = 0;
			_imaginary = 0;
		}

		public Complex(double real_part, double imaginary_part)
		{
			_real = real_part;
			_imaginary = imaginary_part;
		}


		public override string ToString()
		{
			if (_imaginary == 0)
			{
				return $"{_real}";
			}
			else
            {
				return $"{_real} + {_imaginary}i ";
			}
		}

		public static Complex operator +(Complex number1, Complex number2)
        {
			Complex res = new Complex();
			res._real = (number1._real + number2._real);
			res._imaginary = (number1._imaginary + number2._imaginary);

			return res;
		}
		public static Complex operator -(Complex number1, Complex number2)
        {
			Complex res = new Complex();
			res._real = (number1._real - number2._real);
			res._imaginary = (number1._imaginary - number2._imaginary);

			return res;
		}
		public static Complex operator *(Complex number1, Complex number2)                  //z = z1 * z2 = (a1a2 - b1b2) + (a1b2 + b1a2)i
		{
			Complex res = new Complex();
			res._real = ((number1._real * number2._real) - (number1._imaginary * number2._imaginary));
			res._imaginary = ((number1._real * number2._imaginary) + (number1._imaginary * number2._real));

			return res;
		}
		public static Complex operator /(Complex number1, Complex number2)                  //z = z1 / z2 = ((a1a2 + b1b2) / a2^2 + b2^2) + ((a2b1 - a1b2) / a2^2 + b2^2)i
		{
			Complex res = new Complex();
			res._real = (((number1._real * number2._real) + (number1._imaginary * number2._imaginary)) / ((number2._real * number2._real) + (number2._imaginary * number2._imaginary)));
			res._imaginary = (((number2._real * number1._imaginary) - (number1._real * number2._imaginary)) / ((number2._real * number2._real) + (number2._imaginary * number2._imaginary)));

			return res;
		}

}
}
