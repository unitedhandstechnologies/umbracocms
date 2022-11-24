[
    {
        "name": "Contact location container",
        "alias": "contactLocationContainer",
        "view": "/App_Plugins/DocTypeGridEditor/Views/doctypegrideditor.html",
        "render": "/App_Plugins/DocTypeGridEditor/Render/DocTypeGridEditor.cshtml",
        "icon": "icon-location-nearby color-green",
        "config": {
            "allowedDocTypes": ["oContactLocationContainer"],
            "nameTemplate": "",
            "enablePreview": false,
            "viewPath": "/Views/Partials/oskiPartials/",
            "previewViewPath": "/Views/Partials/oskiPartials/",
            "previewCssFilePath": "",
            "previewJsFilePath": ""
        }
    },
    {
        "name": "Contact map container",
        "alias": "contactMapContainer",
        "view": "/App_Plugins/DocTypeGridEditor/Views/doctypegrideditor.html",
        "render": "/App_Plugins/DocTypeGridEditor/Render/DocTypeGridEditor.cshtml",
        "icon": "icon-map color-green",
        "config": {
            "allowedDocTypes": ["oContactMapContainer"],
            "nameTemplate": "",
            "enablePreview": false,
            "viewPath": "/Views/Partials/oskiPartials/",
            "previewViewPath": "/Views/Partials/oskiPartials/",
            "previewCssFilePath": "",
            "previewJsFilePath": ""
        }
    },
    {
        "name": "Rich text editor",
        "alias": "richTextEditor",
        "view": "/App_Plugins/DocTypeGridEditor/Views/doctypegrideditor.html",
        "render": "/App_Plugins/DocTypeGridEditor/Render/DocTypeGridEditor.cshtml",
        "icon": "icon-edit color-green",
        "config": {
            "allowedDocTypes": ["oRTE"],
            "nameTemplate": "",
            "enablePreview": false,
            "viewPath": "/Views/Partials/oskiPartials/",
            "previewViewPath": "/Views/Partials/oskiPartials/",
            "previewCssFilePath": "",
            "previewJsFilePath": ""
        }
    },
    {
        "name": "Search container",
        "alias": "searchContainer",
        "view": "/App_Plugins/DocTypeGridEditor/Views/doctypegrideditor.html",
        "render": "/App_Plugins/DocTypeGridEditor/Render/DocTypeGridEditor.cshtml",
        "icon": "icon-search color-green",
        "config": {
            "allowedDocTypes": ["oSearchContainer"],
            "nameTemplate": "",
            "enablePreview": false,
            "viewPath": "/Views/Partials/oskiPartials/",
            "previewViewPath": "/Views/Partials/oskiPartials/",
            "previewCssFilePath": "",
            "previewJsFilePath": ""
        }
    },
    {
        "name": "Image",
        "nameTemplate": "{{ value && value.udi ? (value.udi | ncNodeName) : '' }}",
        "alias": "media",
        "view": "media",
        "icon": "icon-picture color-green"
    },
    {
        "name": "Macro",
        "nameTemplate": "{{ value && value.macroAlias ? value.macroAlias : '' }}",
        "alias": "macro",
        "view": "macro",
        "icon": "icon-settings-alt"
    },
    {
        "name": "Embed",
        "alias": "embed",
        "view": "embed",
        "icon": "icon-movie-alt color-green"
    },
    {
        "name": "Headline",
        "nameTemplate": "{{ value }}",
        "alias": "headline",
        "view": "textstring",
        "icon": "icon-coin",
        "config": {
            "style": "font-size: 36px; line-height: 45px; font-weight: bold",
            "markup": "<h1>#value#</h1>"
        }
    },
    {
        "name": "Cards container",
        "alias": "cardsContainer",
        "view": "/App_Plugins/DocTypeGridEditor/Views/doctypegrideditor.html",
        "render": "/App_Plugins/DocTypeGridEditor/Render/DocTypeGridEditor.cshtml",
        "icon": "icon-multiple-credit-cards color-green",
        "config": {
            "allowedDocTypes": ["oCardsContainer"],
            "nameTemplate": "",
            "enablePreview": false,
            "viewPath": "/Views/Partials/oskiPartials/",
            "previewViewPath": "/Views/Partials/oskiPartials/",
            "previewCssFilePath": "",
            "previewJsFilePath": ""
        }
    },
    {
        "name": "Links container",
        "alias": "linksContainer",
        "view": "/App_Plugins/DocTypeGridEditor/Views/doctypegrideditor.html",
        "render": "/App_Plugins/DocTypeGridEditor/Render/DocTypeGridEditor.cshtml",
        "icon": "icon-link color-green",
        "config": {
            "allowedDocTypes": ["oLinksContainer"],
            "nameTemplate": "",
            "enablePreview": false,
            "viewPath": "/Views/Partials/oskiPartials/",
            "previewViewPath": "/Views/Partials/oskiPartials/",
            "previewCssFilePath": "",
            "previewJsFilePath": ""
        }
    },
    {
        "name": "Slider container",
        "alias": "sliderContainer",
        "view": "/App_Plugins/DocTypeGridEditor/Views/doctypegrideditor.html",
        "render": "/App_Plugins/DocTypeGridEditor/Render/DocTypeGridEditor.cshtml",
        "icon": "icon-slideshow color-green",
        "config": {
            "allowedDocTypes": ["oSliderContainer"],
            "nameTemplate": "",
            "enablePreview": false,
            "viewPath": "/Views/Partials/oskiPartials/",
            "previewViewPath": "/Views/Partials/oskiPartials/",
            "previewCssFilePath": "",
            "previewJsFilePath": ""
        }
    },
    {
        "name": "Slider v2 container",
        "alias": "sliderV2Container",
        "view": "/App_Plugins/DocTypeGridEditor/Views/doctypegrideditor.html",
        "render": "/App_Plugins/DocTypeGridEditor/Render/DocTypeGridEditor.cshtml",
        "icon": "icon-slideshow color-green",
        "config": {
            "allowedDocTypes": ["oSliderV2Container"],
            "nameTemplate": "",
            "enablePreview": false,
            "viewPath": "/Views/Partials/oskiPartials/",
            "previewViewPath": "/Views/Partials/oskiPartials/",
            "previewCssFilePath": "",
            "previewJsFilePath": ""
        }
    },
    {
        "name": "Contact container",
        "alias": "contactContainer",
        "view": "/App_Plugins/DocTypeGridEditor/Views/doctypegrideditor.html",
        "render": "/App_Plugins/DocTypeGridEditor/Render/DocTypeGridEditor.cshtml",
        "icon": "icon-umb-contour color-green",
        "config": {
            "allowedDocTypes": ["oContactContainer"],
            "nameTemplate": "",
            "enablePreview": false,
            "viewPath": "/Views/Partials/oskiPartials/",
            "previewViewPath": "/Views/Partials/oskiPartials/",
            "previewCssFilePath": "",
            "previewJsFilePath": ""
        }
    },
    {
        "name": "Image Info",
        "alias": "imageInfoContainer",
        "view": "/App_Plugins/DocTypeGridEditor/Views/doctypegrideditor.html",
        "render": "/App_Plugins/DocTypeGridEditor/Render/DocTypeGridEditor.cshtml",
        "icon": "icon-imac color-green",
        "config": {
            "allowedDocTypes": ["oImageInfoContainer"],
            "nameTemplate": "",
            "enablePreview": false,
            "viewPath": "/Views/Partials/oskiPartials/",
            "previewViewPath": "/Views/Partials/oskiPartials/",
            "previewCssFilePath": "",
            "previewJsFilePath": ""
        }
    },
    {
        "name": "Card List",
        "alias": "cardList",
        "view": "/App_Plugins/DocTypeGridEditor/Views/doctypegrideditor.html",
        "render": "/App_Plugins/DocTypeGridEditor/Render/DocTypeGridEditor.cshtml",
        "icon": "icon-list color-green",
        "config": {
            "allowedDocTypes": ["oCardList"],
            "nameTemplate": "",
            "enablePreview": false,
            "viewPath": "/Views/Partials/oskiPartials/",
            "previewViewPath": "/Views/Partials/oskiPartials/",
            "previewCssFilePath": "",
            "previewJsFilePath": ""
        }
    },
    {
        "name": "Call To Action",
        "alias": "callToAction",
        "view": "/App_Plugins/DocTypeGridEditor/Views/doctypegrideditor.html",
        "render": "/App_Plugins/DocTypeGridEditor/Render/DocTypeGridEditor.cshtml",
        "icon": "icon-window-popin color-green",
        "config": {
            "allowedDocTypes": ["oCallToAction"],
            "nameTemplate": "",
            "enablePreview": false,
            "viewPath": "/Views/Partials/oskiPartials/",
            "previewViewPath": "/Views/Partials/oskiPartials/",
            "previewCssFilePath": "",
            "previewJsFilePath": ""
        }
    },
    {
        "name": "Quick Contact Form",
        "alias": "quickcontactform",
        "view": "/App_Plugins/DocTypeGridEditor/Views/doctypegrideditor.html",
        "render": "/App_Plugins/DocTypeGridEditor/Render/DocTypeGridEditor.cshtml",
        "icon": "icon-user-females color-green",
        "config": {
            "allowedDocTypes": ["oQuickContactContainer"],
            "nameTemplate": "",
            "enablePreview": false,
            "viewPath": "/Views/Partials/oskiPartials/",
            "previewViewPath": "/Views/Partials/oskiPartials/",
            "previewCssFilePath": "",
            "previewJsFilePath": ""
        }
    },
    {
        "name": "Quote",
        "alias": "quote",
        "view": "/App_Plugins/DocTypeGridEditor/Views/doctypegrideditor.html",
        "render": "/App_Plugins/DocTypeGridEditor/Render/DocTypeGridEditor.cshtml",
        "icon": "icon-quote color-green",
        "config": {
            "allowedDocTypes": ["oQuote"],
            "nameTemplate": "",
            "enablePreview": false,
            "viewPath": "/Views/Partials/oskiPartials/",
            "previewViewPath": "/Views/Partials/oskiPartials/",
            "previewCssFilePath": "",
            "previewJsFilePath": ""
        }
    },
    {
        "name": "Code Fregment",
        "alias": "codeFragment",
        "view": "/App_Plugins/DocTypeGridEditor/Views/doctypegrideditor.html",
        "render": "/App_Plugins/DocTypeGridEditor/Render/DocTypeGridEditor.cshtml",
        "icon": "icon-code color-green",
        "config": {
            "allowedDocTypes": ["oCodeFragment"],
            "nameTemplate": "",
            "enablePreview": false,
            "viewPath": "/Views/Partials/oskiPartials/",
            "previewViewPath": "/Views/Partials/oskiPartials/",
            "previewCssFilePath": "",
            "previewJsFilePath": ""
        }
    },
    {
        "name": "Plans Cards",
        "alias": "plansCardsContainer",
        "view": "/App_Plugins/DocTypeGridEditor/Views/doctypegrideditor.html",
        "render": "/App_Plugins/DocTypeGridEditor/Render/DocTypeGridEditor.cshtml",
        "icon": "icon-playing-cards color-green",
        "config": {
            "allowedDocTypes": ["oPlansCardsContainer"],
            "nameTemplate": "",
            "enablePreview": false,
            "viewPath": "/Views/Partials/oskiPartials/",
            "previewViewPath": "/Views/Partials/oskiPartials/",
            "previewCssFilePath": "",
            "previewJsFilePath": ""
        }
    },
    {
        "name": "Question & Answer",
        "alias": "questionAnswerContainer",
        "view": "/App_Plugins/DocTypeGridEditor/Views/doctypegrideditor.html",
        "render": "/App_Plugins/DocTypeGridEditor/Render/DocTypeGridEditor.cshtml",
        "icon": "icon-lightbulb color-green",
        "config": {
            "allowedDocTypes": ["oQuestionAnswerContainer"],
            "nameTemplate": "",
            "enablePreview": false,
            "viewPath": "/Views/Partials/oskiPartials/",
            "previewViewPath": "/Views/Partials/oskiPartials/",
            "previewCssFilePath": "",
            "previewJsFilePath": ""
        }
    },
    {
        "name": "Full Screen teaser",
        "alias": "fullScreenTopContainer",
        "view": "/App_Plugins/DocTypeGridEditor/Views/doctypegrideditor.html",
        "render": "/App_Plugins/DocTypeGridEditor/Render/DocTypeGridEditor.cshtml",
        "icon": "icon-fullscreen color-green",
        "config": {
            "allowedDocTypes": ["oFullScreenTopContainer"],
            "nameTemplate": "",
            "enablePreview": false,
            "viewPath": "/Views/Partials/oskiPartials/",
            "previewViewPath": "/Views/Partials/oskiPartials/",
            "previewCssFilePath": "",
            "previewJsFilePath": ""
        }
    },
]