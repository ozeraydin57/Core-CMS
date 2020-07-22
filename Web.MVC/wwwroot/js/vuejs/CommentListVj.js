var app = new Vue({
    el: '#vueCommentList',
    data: {
        postId: document.getElementById('postId').dataset.title,
        data: {},
        error: null
    },
    methods: {
        listComment: function () {
            $.ajax({   
                method: "post",
                url: "/PostComment/List",
                data: {
                    postId: this.postId,
                },
                success: (data) => {
                    if (data.success)
                        this.data = data.data;
                }
            });
        }
    },
    mounted: function () {
        this.listComment();
    }
})