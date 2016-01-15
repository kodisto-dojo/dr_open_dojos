package expressions

import org.scalatest.FlatSpec

class BinaryOptSpec extends FlatSpec {
  val x = Number(10)
  val zero = Number(0)
  val one = Number(1)

  behavior of "A Binary opt expression"

  /* Addition */
  it should "be x if x + 0" in {
    val exp = BinaryOpt(x, "+", zero)
    val actual = Expression.simplify(exp)
    assert(x == actual)
  }

  it should "be x if 0 + x" in {
    val exp = BinaryOpt(zero, "+", x)
    val actual = Expression.simplify(exp)
    assert(x == actual)
  }

  it should "be x if x - 0" in {
    val exp = BinaryOpt(x, "-", zero)
    val actual = Expression.simplify(exp)
    assert(x == actual)
  }

  it should "be Unary('-', x) if 0 - x" in {
    val exp = BinaryOpt(zero, "-", x)
    val expected = UnaryOpt("-", x)
    val actual = Expression.simplify(exp)
    assert(expected == actual)
  }

  it should "be Zero if x - x" in {
    val exp = BinaryOpt(x, "-", x)
    val actual = Expression.simplify(exp)
    assert(zero == actual)
  }

  /* Multiplication  */
  it should "be Zero if x * 0" in {
    val exp = BinaryOpt(x, "*", zero)
    val actual = Expression.simplify(exp)
    assert(zero == actual)
  }

  it should "be Zero if 0 * x" in {
    val exp = BinaryOpt(zero, "*", x)
    val actual = Expression.simplify(exp)
    assert(zero == actual)
  }

  it should "be x if x * 1" in {
    val exp = BinaryOpt(x, "*", one)
    val actual = Expression.simplify(exp)
    assert(x == actual)
  }

  it should "be x if 1 * x" in {
    val exp = BinaryOpt(one, "*", x)
    val actual = Expression.simplify(exp)
    assert(x == actual)
  }

  /* Division  */
  it should "not accept Div By Zero" in {
    intercept[IllegalArgumentException] {
      BinaryOpt(x, "/", zero)
    }
  }

  it should "be x if x / 1" in {
    val exp = BinaryOpt(x, "/", one)
    val actual = Expression.simplify(exp)
    assert(x == actual)
  }

  it should "be One if x / x" in {
    val exp = BinaryOpt(x, "/", x)
    val actual = Expression.simplify(exp)
    assert(one == actual)
  }
  
  /* Illegal operators */
  it should "not accept invalid operator ** " in {
    intercept[IllegalArgumentException] {
      BinaryOpt(x, "**", x)
    }
  }
}