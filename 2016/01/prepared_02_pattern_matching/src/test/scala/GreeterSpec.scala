import org.scalatest.FlatSpec

class GreeterSpec  extends FlatSpec {
  "A Greeter " should " have a name and greet me" in {
    val greeter = Greeter("Peter")
    assert("Hello Lorenzo, my name is Peter." == (greeter greetMe "Lorenzo"))
  }
}