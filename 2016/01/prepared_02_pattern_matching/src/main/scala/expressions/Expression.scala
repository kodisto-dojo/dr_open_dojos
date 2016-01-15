package expressions

abstract sealed class Expression

case class Var(name: String) extends Expression {
  require(name != null)
  require(!name.trim.isEmpty)
}

case class Number(num: Double) extends Expression
case class UnaryOpt(opt: String, exp: Expression) extends Expression
case class BinaryOpt(left: Expression, opt: String, right: Expression) extends Expression {
  private val allowedOperatos = List("+", "-", "*", "/")
  
  require(allowedOperatos contains opt) 
  
  if (opt == "/") {
    require(right != Number(0), "Illegal expression => div by zero")
  }
}

object Expression {
  val zero = Number(0)

  def simplify(exp: Expression): Expression =
    exp match {
      case UnaryOpt("+", e) => simplify(e)
      case UnaryOpt(op, Number(0)) => zero
      
      case BinaryOpt(e, "+", Number(0)) => simplify(e)
      case BinaryOpt(Number(0), "+", e) => simplify(e)
      case BinaryOpt(e, "-", Number(0)) => simplify(e)
      case BinaryOpt(Number(0), "-", e) => simplify(UnaryOpt("-", simplify(e)))
      case BinaryOpt(a, "-", b) if a == b => zero
      case BinaryOpt(e, "*", Number(0)) => zero
      case BinaryOpt(Number(0), "*", e) => zero
      case BinaryOpt(e, "*", Number(1)) => simplify(e)
      case BinaryOpt(Number(1), "*", e) => simplify(e)
      case BinaryOpt(e, "/", Number(1)) => simplify(e)
      case BinaryOpt(le, "/", ri) if le == ri => Number(1)

      case _ => exp
    }
}