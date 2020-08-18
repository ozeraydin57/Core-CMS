var app = new Vue({
    el: '#vueNewsletter',
    data: {
        email: null,
        response: '',
        disabledButton: false,
        error: null
    },
    methods: {
        sendMessage: function () {
            $('.alertSuccNewsletter').hide();
            $('.alertErrNewsletter').hide();
            if (this.checkForm()) {
                this.disabledButton = true;
                this.response = "işleminiz yapılıyor.."
                $.ajax({
                    method: "post",
                    url: "/Newsletter/Create",
                    data: {
                        Email: this.email,
                    },
                    success: (data) => {
                        if (data.success)
                            this.response = data;
                        else
                            this.disabledButton = false;
                        $('.alertSuccNewsletter').fadeIn();
                        $('.alertErrNewsletter').hide();
                    }
                });
            }
        },
        checkForm: function () {
            var mailformat = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
            if (this.email) {
                if (this.email.match(mailformat)) {
                    return true;
                }
                else {
                    this.error = "Lütfen doğru eposta adresi giriniz!";
                }
            } else
                this.error = "Lütfen eposta adresini giriniz!"
            $('.alertErrNewsletter').fadeIn();
            return false;
        }
    }
})