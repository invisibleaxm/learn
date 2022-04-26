import (
	"strings"
)

#Person: {
	Name:  string & strings.MinRunes(3) & strings.MaxRunes(22)
	Email: =~"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$"
	Age?:  int & >0 & <140
	Job?:  string
}

#Engineer: #Person & {
	Job: string | *"Engineer"
}

Bob: #Engineer & {
	Name:  "Bob Smith"
	Email: "bob@smith.com"
	Age:   42
	Job:   "Carpenter"
}
