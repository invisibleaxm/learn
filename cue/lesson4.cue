import (
	"strings"
)

#Person: {
	//further constrain to a min and max length
	Name:  string & strings.MinRunes(3) & strings.MaxRunes(22)
	Email: =~"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$"
	Age?:  int & >0 & <140
}

Bob: #Person & {
	Name:  "Bob Smith"
	Email: "bob@smith.com"
	Age:   42
}
