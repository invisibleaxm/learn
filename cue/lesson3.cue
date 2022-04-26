#Person: {
	Name:  string
	Email: string
	Age?:  int
}

Bob: #Person & {
	Name:  "Bob Smit"
	Email: "bob@smith.com"
	//Age is optional
}
