package expressions

import org.scalatest.FlatSpec

class VarSpec extends FlatSpec {
  val x = Var("age")
  behavior of "A Variable expression"
  it should "be reduced to itself" in {
    val actual = Expression.simplify(x)
    assert(x == actual)
  }

  it should "not take null name" in {
    intercept[IllegalArgumentException] {
      Var(null)
    }
  }

  it should "not take empty name" in {
    intercept[IllegalArgumentException] {
      Var("")
    }
  }

  it should "not take blank name" in {
    intercept[IllegalArgumentException] {
      Var(" ")
    }
  }
}