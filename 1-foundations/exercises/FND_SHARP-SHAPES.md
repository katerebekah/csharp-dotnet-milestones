### Another possibility: Eliza's Sharp Shapes
Eliza had a really good OOP exercise "Sharp Shapes" which was (unfortunately) oriented towards and implemented in WPF.  I'm not sure how easy/hard it would be to assign it without also requiring students to take on WPF also.  Perhaps someone (TA) could implement a WPF viewer that the students could just use w/out programming to it.  [Needs further investigation.]

https://github.com/elizabrock/SharpShapes

Basics included:
 - shapes w/ 3 or more # sides
 - shapes w/ 4 sides included rectangle, square, rhombus, trapezoid, parallelogram
 - shapes w/ different color fills
 - methods for calculating circumference, area of each shape

E.g.
* write tests for rhombus
* inherit from Shape
* to compile:
  * generate stubs
  * leave `throw new not implemented exception`
  * run tests => fail
  * then move other properties/fields from rectangle into rhombus
  * get test of sidesCount() to pass

Many of the key math/geometry details can be found @:  
http://mathworld.wolfram.com/

More details, including implementation notes from Sonda, are in "Orphaned-for-Now" section, EXERCISES folder.
