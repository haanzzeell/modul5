class userService(object):
    """description of class"""
        # constructor baru __init__ dengan parameter self, email, dan password
    def __init__(self, email, password):
        # menset current instance email dan password dengan paramater
        self.email = email
        self.password = password
        # membuat data baru bernilai array 2 dimensi berisi email, password, dan role user yang bisa login
        self.data = {
            "HanaAdilah@gmail.com" : {
                "email"     : "HanaAdilah@gmail.com",
                "password"  : "12345",
                "role"      : "superadmin"
            },
            "GunawanPrasetya@gmail.com" : {
                "email"     : "GunawanPrasetya@gmail.com",
                "password"  : "12345",
                "role"      : "user"
            }
        }
    # function login dengan parameter self
    def login(self):
        # memanggil function checkCredentials dengan variable get_data
        get_data = self.checkCredentials()
        # mengecek apakah function checkCredentials mengembalikan nilai
        if get_data:
            # jika true, maka akan menampilkan welcome role, dan email user yang login
            print("\nWelcome ",get_data['role'])
            print("Logged it as user email: ",get_data['email'])
        else:
            # jika false maka akan menampilkan invalid login
            print("\nInvalid Login!\n")
    #function checkCredentials dengan parameter self
    def checkCredentials(self):
        # membuat perulangan untuk setiap nilai didalam data
        for value in self.data:
            # jika nilai dalam data sama dengan isi paramater email
            if value == self.email:
                # maka akan menyimpan info user yang login kedalam get_data_user
                get_data_user = self.data[value]
                # jika isi parameter password sama dengan password dalam data user
                if self.password == get_data_user['password']:
                    # maka akan mengembalikan data user
                    return get_data_user
                else:
                    #jika tidak maka akan mengembalikkan boolean false
                    return False
