package main

import (
	"dagger.io/dagger"
	"fmt"
	"rsc.io/quote"
)

var message = "test"

func main() {
	var x int = 5
	fmt.Println("Hello, World!")
	fmt.Println("Another Line")
	for x > 0 {
		fmt.Println(x)
		x--
	}
	fmt.Println(quote.Go())

}
