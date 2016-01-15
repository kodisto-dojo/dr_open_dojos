class Greeter(val name: String) {
  def greetMe(personName: String) = "Hello " + personName + ", my name is " + name + "."
}

object Greeter {
  def apply(name: String) = new Greeter(name)
}