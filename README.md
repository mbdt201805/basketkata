# Basket Kata

## Instructions

See instructions.pdf for the instructions supplied.

## Starting decisions

- I will implement this as as class library. This will allow me to focus on modelling the domain.
- I will test drive this code using a classicist style of TDD, letting the implementation emerge through triangulation. This feels like the best approach for a problem whose core is a calculation algorithm, and which doesn't have many immediately obvious interacting parts.
- I will avoid primitives in the public interface of the system. By making use of the type system from the beginning I may find opportunities for classes to inform the refactoring by attracting behaviour.
- I will allow my basket to have mutable state. This means the `Add` method will be `void`.
- The `Total` method will be a query, returning the amount.
