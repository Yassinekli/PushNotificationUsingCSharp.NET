
self.addEventListener('install', function (event) {
    console.log('[Service Worker] installed ', event);
});

self.addEventListener('activate', function (event) {
    console.log('[Service Worker] activated ', event);
});

self.addEventListener('fetch', function (event) {
    console.log('[Service Worker] fetching ', event);
});

self.addEventListener('push', function (event) {
    if (event.data) {
        var options = {
            icon: '/Resouces/images/icon-512x512.png',
            badge: '/Resouces/images/icon-128x128.png',
            vibrate: [150, 50, 150]
        };
        event.waitUntil(
            self.registration.showNotification(event.data.text(), options)
        );
    }
});