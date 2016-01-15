package expressions

import org.scalatest.FlatSpec

class UnaryOptSpec extends FlatSpec {
  val x = Number(10)
  val zero = Number(0)
  behavior of "An Unary opt expression"
  it should "be x if +x" in {
    val exp = UnaryOpt("+", x)
    val actual = Expression.simplify(exp)
    assert(x == actual)
  }

  it should "be x if ++x" in {
    val exp = UnaryOpt("+", UnaryOpt("+", x))
    val actual = Expression.simplify(exp)
    assert(x == actual)
  }
  
  it should "be Number(0) if +0" in {
    val exp = UnaryOpt("+", zero)
    val actual = Expression.simplify(exp)
    assert(zero == actual)
  }
  
  it should "be Number(0) if -0" in {
    val exp = UnaryOpt("-", zero)
    val actual = Expression.simplify(exp)
    assert(zero == actual)
  }
}