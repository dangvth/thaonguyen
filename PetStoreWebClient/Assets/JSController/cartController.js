var cart = {
    init: function () {
        cart.regEvents();
    },
    regEvents: function () {
        $('#btnContinute').off('click').on('click', function () {
            window.location.href = "/";
        });

        $('#btnUpdate').off('click').on('click', function () {
            var listProduct = $('.txtQuantity');
            var cartList = [];
            $.each(listProduct, function (i, item) {
                //var typeID = $(item).data('id');
                //var checkPF = typeID.startsWith("PFD");
                //var checkP = typeID.startsWith("PET");
                //var checkPM = typeID.startsWith("PDM");
                //var checkPT = typeID.startsWith("PTS");

                //if (checkPF != null) {
                //    cartList.push({
                //        Quantity: $(item).val(),
                //        PetFood: {
                //            pf_id: $(item).data('id')
                //        }
                //    });
                //}
                //if (checkP != null) {
                //    cartList.push({
                //        Quantity: $(item).val(),
                //        Pet: {
                //            p_id: $(item).data('id')
                //        }
                //    });
                //}
                //if (checkPM != null) {
                //    cartList.push({
                //        Quantity: $(item).val(),
                //        PetMedicine: {
                //            pm_id: $(item).data('id')
                //        }
                //    });
                //}
                //if (checkPT != null) {
                //    cartList.push({
                //        Quantity: $(item).val(),
                //        PetToys: {
                //            pt_id: $(item).data('id')
                //        }
                //    });
                //}
                cartList.push({
                    Quantity: $(item).val(),
                    PetFood: {
                        pf_id: $(item).data('id')
                    }
                });
            });

            $.ajax({
                url: '/cart/Update',
                data: { cartModel: JSON.stringify(cartList) },
                dataType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {
                        window.location.href = "/cart";
                    }
                }
            });
        });
    }
}
cart.init();