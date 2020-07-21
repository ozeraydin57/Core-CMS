var app = new Vue({
    el: '#vueCommentList',
    data: {
        response: '',
        data: {},
        error: null
    },
    methods: {
        listComment: function (postId) {
            $.ajax({
                method: "post",
                url: "/PostComment/List",
                data: {
                    postId: postId,
                },
                success: (data) => {
                    
                    if (data.success)
                        this.data = data.data;

                    console.log(this.data);
                }
            });
        }
    },
    mounted: function () {
        this.listComment(30)
    }

})