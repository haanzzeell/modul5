# mengimport class userService dari file userService
from userService import userService

print("System Login Kelompok 41!\n")
# membaca input user dan menyimpan dalam variabel email
email = input("Email: ")
# membaca input user dan menyimpan dalam variabel password
password = input("Password: ")
# membuat constructor baru userService dengan isi parameter input email dan password 
# dengan variabel get_class
get_class = userService(email,password)
# memanggil function login pada class userService
get_class.login()

