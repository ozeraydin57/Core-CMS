var app = new Vue({
    el: '#vueApp',
    data: {
        name: null,
        email: null,
        phone: null,
        subject: null,
        message: null,
        response: '',
        disabledButton: false,
        error: null
    },
    methods: {
        sendMessage: function () {
            $('.alertSucc').hide();
            $('.alertErr').hide();
            if (this.checkForm()) {

                this.disabledButton = true;
                this.response = "Mesajınız iletiliyor.."

                $.ajax({
                    method: "post",
                    url: "/Contact/Create",
                    data: {
                        Name: this.name,
                        Email: this.email,
                        Phone: this.phone,
                        Subject: this.subject,
                        message: this.message,
                    },
                    success: (data) => {
                        console.log(data);
                        if (data.success)
                            this.response = data;
                        else
                            this.disabledButton = false;
                        $('.alertSucc').fadeIn();
                        $('.alertErr').hide();
                    }
                });

            }
        },
        checkForm: function () {
            if (this.name && this.email && this.message) {
                var mailformat = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
                if (this.email.match(mailformat)) {
                    return true;
                }
                else {
                    this.error = "Lütfen doğru eposta adresi giriniz!";
                }
            } else
                this.error = "Lütfen * ile işaretlenmiş alanları doldurunuz!"
            $('.alertErr').fadeIn();
            return false;
        }
    }
})