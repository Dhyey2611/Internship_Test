    function openUserPopup() {
        var userId = document.getElementById("hiddenUserId").value;

        $.ajax({
            url: '/Home/GetUserPopupInfo',
            type: 'GET',
            data: { userId: userId },
            success: function(data) {
                $("#modalName").text(data.name);
                $("#modalFavourite").text(data.favouriteItem);
                $("#modalPrevious").text(data.previousOrder);
                $("#modalAddress").text(data.address);
                $("#modalReward").text(data.rewardInfo);
                $("#modalRefund").text(data.refundAmount);
                $("#modalWallet").text(data.walletAmount);
                $("#modalBenefit").text(data.benefitInfo);
                $("#modalUpdate").text(data.appUpdateVersion);

                var modal = new bootstrap.Modal(document.getElementById('userInfoModal'));
                modal.show();
            },
            error: function () {
                alert("Failed to load user info.");
            }
        });
    }
