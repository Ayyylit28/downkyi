﻿namespace DownKyi.Images
{
    public class NormalIcon
    {
        private static NormalIcon instance;
        public static NormalIcon Instance()
        {
            if (instance == null)
            {
                instance = new NormalIcon();
            }
            return instance;
        }

        public NormalIcon()
        {
            Play = new VectorImage
            {
                Height = 16,
                Width = 14.75,
                Data = @"M869.03 707.93 l-465.29 281.31 q-86.66 49.32 -178.65 28.65 q-91.99 -20.66 -146.65 -103.31 q-36 -56 -36 -121.33
                         l0 -562.61 q2.67 -97.32 69.33 -162.64 q66.66 -65.32 167.98 -67.99 q66.66 0 123.99 34.66 l465.29 281.31
                         q83.99 53.33 105.99 143.32 q22 89.99 -30 173.98 q-29.33 46.66 -75.99 74.66 Z",
                Fill = "#FF000000"
            };

            Like = new VectorImage
            {
                Height = 14,
                Width = 16,
                Data = @"M291.53 894.6 l0 -642.53 l4.66 0 l179.59 -220.4 q29.15 -29.15 69.97 -31.49 q40.81 -2.33 72.29 24.5
                         q16.33 16.32 25.66 37.31 q9.33 20.99 7 45.48 l-7 144.6 l274.04 0 q25.65 0 48.39 11.08 q22.74 11.08 39.07 32.07
                         q13.99 19.82 17.49 44.31 q3.5 24.49 -2.33 46.64 l-116.62 382.49 q-15.16 54.81 -57.14 88.63 q-41.98 33.81 -100.28 37.31
                         l-454.79 0 ZM225.06 894.6 l-93.29 0 q-34.98 2.33 -65.3 -14 q-30.32 -16.33 -47.81 -47.81 q-17.49 -31.49 -18.66 -64.13
                         l0 -385.99 q0 -36.15 17.49 -65.89 q17.49 -29.73 48.98 -46.05 q16.32 -8.17 32.65 -12.25 q16.33 -4.08 32.65 -6.41 l93.29 0
                         l0 642.53 Z",
                Fill = "#FF000000"
            };

            Favorite = new VectorImage
            {
                Height = 16,
                Width = 16,
                Data = @"M772.12 303.28 q-37.33 -5.83 -66.49 -28 q-29.16 -22.16 -44.32 -55.99 l-83.99 -176.13 q-22.16 -43.16 -65.91 -43.16
                         q-43.74 0 -69.4 43.16 l-79.32 176.13 q-17.49 33.83 -46.07 55.99 q-28.58 22.17 -64.74 28 l-188.97 29.16
                         q-45.49 9.33 -58.9 48.99 q-13.42 39.66 18.09 75.82 l142.31 146.98 q25.66 24.49 35.57 58.32 q9.91 33.83 5.25 69.99
                         l-32.66 204.13 q-5.83 48.99 29.75 73.49 q35.57 24.5 79.9 3.5 l159.8 -87.48 q33.83 -19.83 71.74 -19.83
                         q37.91 0 71.74 19.83 l160.97 87.48 q43.16 21 77.57 -3.5 q34.41 -24.5 32.08 -73.49 l-37.33 -204.13
                         q-4.67 -36.16 5.25 -69.99 q9.91 -33.83 35.57 -58.32 l142.31 -146.98 q31.5 -36.16 18.09 -75.82
                         q-13.42 -39.66 -58.91 -48.99 l-188.97 -29.16 Z",
                Fill = "#FF000000"
            };

            Share = new VectorImage
            {
                Height = 14,
                Width = 16,
                Data = @"M453.23 283.64 l0 -219.44 q1.16 -26.85 18.67 -45.53 q17.51 -18.68 44.36 -18.68 q23.34 0 40.85 15.17 l441.21 375.85
                         q25.68 22.18 25.68 56.61 q0 34.43 -25.68 57.78 l-441.21 375.85 q-19.84 16.34 -46.11 14 q-26.26 -2.34 -42.61 -22.18
                         q-15.17 -18.67 -15.17 -42.02 l0 -201.93 q-156.41 0 -249.79 61.87 q-93.38 61.87 -178.58 183.25 q-4.67 5.84 -14.01 5.25
                         q-9.34 -0.59 -10.51 -19.25 q-5.83 -241.62 87.54 -405.62 q93.38 -164 365.35 -171 Z",
                Fill = "#FF000000"
            };

            CloudDownload = new VectorImage
            {
                Height = 32,
                Width = 48,
                Data = @"M19.4,10c-0.7-3.4-3.7-6-7.4-6C9.1,4,6.6,5.6,5.3,8C2.3,8.4,0,10.9,0,14c0,3.3,2.7,6,6,6h13c2.8,0,5-2.2,5-5
		                 C24,12.4,22,10.2,19.4,10z M19,18H6c-2.2,0-4-1.8-4-4c0-2.1,1.5-3.8,3.6-4l1.1-0.1L7.1,9C8.1,7.1,9.9,6,12,6c2.6,0,4.9,1.9,5.4,4.4
		                 l0.3,1.5l1.5,0.1c1.6,0.1,2.8,1.4,2.8,3C22,16.6,20.6,18,19,18z M13.4,10h-2.9v3H8l4,4l4-4h-2.6V10z",
                Fill = "#FF000000"
            };

            Folder = new VectorImage
            {
                Height = 32,
                Width = 40,
                Data = @"M20 6h-8l-2-2H4c-1.1 0-1.99.9-1.99 2L2 18c0 1.1.9 2 2 2h16c1.1 0 2-.9 2-2V8c0-1.1-.9-2-2-2zm0 12H4V8h16v10z",
                Fill = "#FF000000"
            };

            Downloading = new VectorImage
            {
                Height = 16,
                Width = 16,
                Data = @"M1,11.7c0.6,0,1,0.5,1,1V24H1.4C0.6,24,0,23.4,0,22.6c0,0,0,0,0,0v-9.9C0,12.1,0.5,11.7,1,11.7C1,11.7,1,11.7,1,11.7z
                         M0,21.9h24v0.7c0,0.8-0.6,1.4-1.3,1.4H1.4C0.6,24,0,23.4,0,22.6V21.9z
                         M23,11.7c0.6,0,1,0.5,1,1v9.9c0,0.8-0.6,1.4-1.3,1.4H22V12.7C22,12.1,22.5,11.7,23,11.7C23,11.7,23,11.7,23,11.7z M13,17.4
                         h-2V1c0-0.6,0.4-1,1-1s1,0.5,1,1c0,0,0,0,0,0V17.4z
                         M6.9,12.5c0.4-0.4,1-0.4,1.4,0l4.9,5.1L12.8,18c-0.5,0.5-1.4,0.5-1.9,0l-4-4.1C6.5,13.5,6.5,12.9,6.9,12.5L6.9,12.5z
                         M16.8,12.5c0.4,0.4,0.4,1.1,0,1.5l-4,4.1c-0.5,0.5-1.4,0.5-1.9,0l-0.5-0.5l4.9-5.1C15.8,12.1,16.4,12.1,16.8,12.5L16.8,12.5z",
                Fill = "#FF000000"
            };

            DownloadFinished = new VectorImage
            {
                Height = 16,
                Width = 16,
                Data = @"M12,0C8.6,0.1,5.8,1.3,3.5,3.5S0.1,8.6,0,12c0.1,3.4,1.3,6.2,3.5,8.5S8.6,23.9,12,24c3.4-0.1,6.2-1.3,8.5-3.5
                         s3.4-5.1,3.5-8.5c-0.1-3.4-1.3-6.2-3.5-8.5S15.4,0.1,12,0z M12,22.5c-3-0.1-5.5-1.1-7.4-3.1S1.6,15,1.5,12c0.1-3,1.1-5.5,3.1-7.4
                         S9,1.6,12,1.5c3,0.1,5.5,1.1,7.4,3.1s3,4.4,3.1,7.4c-0.1,3-1.1,5.5-3.1,7.4S15,22.4,12,22.5z
                         M16.5,8.1c0.2-0.2,0.4-0.2,0.6-0.2c0.5,0,0.9,0.4,0.9,0.9c0,0.2-0.1,0.5-0.2,0.6l-6.5,6.5
                         c-0.2,0.2-0.4,0.3-0.6,0.3c-0.2,0-0.5-0.1-0.7-0.3l-3.8-3.7C6.1,12,6,11.7,6,11.5c0-0.2,0.1-0.5,0.3-0.6c0.2-0.2,0.4-0.3,0.6-0.3
                         c0.2,0,0.5,0.1,0.6,0.2l3.1,3.1L16.5,8.1L16.5,8.1z",
                Fill = "#FF000000"
            };

            CoinIcon = new VectorImage
            {
                Height = 20,
                Width = 20,
                Data = @"M473.7 358.8 l0 -54.42 l-129.01 0 q-16.12 0 -27.21 -11.09 q-11.09 -11.09 -11.09 -27.72 q0 -16.63 11.09 -27.21
                         q11.09 -10.58 27.21 -11.59 l334.62 0 q22.17 1.01 32.76 20.16 q10.58 19.15 0 37.8 q-10.59 18.64 -32.76 19.65 l-129.01 0
                         l0 54.42 q93.73 16.13 153.7 83.66 q59.97 67.52 61.98 163.27 l0 23.18 q-1 17.14 -11.59 27.72 q-10.59 10.58 -27.22 10.58
                         q-16.63 0 -27.72 -10.58 q-11.08 -10.58 -11.08 -27.72 l0 -23.18 q-1.01 -62.49 -39.31 -108.35 q-38.3 -45.86 -98.77 -59.96
                         l0 332.6 q0 16.12 -11.09 27.2 q-11.08 11.09 -27.21 11.09 q-16.13 0 -27.22 -11.09 q-11.08 -11.08 -11.08 -27.2 l0 -332.6
                         q-60.47 14.11 -98.77 59.96 q-38.3 45.86 -39.31 108.35 l0 23.18 q0 17.14 -11.09 27.72 q-11.08 10.58 -27.71 10.58
                         q-16.63 0 -27.21 -10.58 q-10.59 -10.58 -11.59 -27.72 l0 -23.18 q2.01 -95.75 61.98 -163.27 q59.97 -67.53 153.7 -83.66
                         ZM512 1024 q-217.7 -6.05 -361.82 -150.17 q-144.13 -144.13 -150.18 -361.83 q6.05 -217.7 150.18 -361.82
                         q144.13 -144.13 361.82 -150.18 q217.7 6.05 361.83 150.18 q144.13 144.13 150.17 361.82 q-6.05 217.7 -150.17 361.83
                         q-144.13 144.13 -361.83 150.17 ZM512 946.39 q184.44 -5.04 306.89 -127.5 q122.46 -122.45 127.5 -306.89
                         q-5.04 -184.44 -127.5 -306.89 q-122.45 -122.46 -306.89 -127.5 q-184.44 5.04 -306.89 127.5 q-122.46 122.45 -127.5 306.89
                         q5.04 184.44 127.5 306.89 q122.45 122.46 306.89 127.5 Z",
                Fill = "#FF000000"
            };

            MoneyIcon = new VectorImage
            {
                Height = 20,
                Width = 20,
                Data = @"M409.2 444.47 l138.08 0 q28.22 -1.01 46.36 -19.15 q18.14 -18.14 18.14 -45.85 q0 -27.72 -18.14 -46.36
                         q-18.14 -18.65 -46.36 -19.66 l-129.01 0 q-4.03 0 -6.55 3.03 q-2.52 3.02 -2.52 6.04 l0 121.95 ZM658.14 469.67
                         q48.38 30.24 68.03 80.63 q19.66 50.39 4.03 105.32 q-15.63 54.93 -58.96 87.18 q-43.34 32.25 -99.78 33.25 l-153.19 0
                         q-36.29 -1 -60.98 -25.19 q-24.69 -24.19 -25.7 -61.48 l0 -366.87 q1.01 -36.28 25.7 -60.47 q24.69 -24.19 60.98 -25.2
                         l129.01 0 q42.33 0 76.6 21.67 q34.26 21.67 52.41 59.47 q18.14 37.79 13.11 78.11 q-5.04 40.31 -31.25 73.57 ZM571.46 522.08
                         l-162.26 0 l0 167.31 q1 9.07 9.07 9.07 l153.19 0 q36.29 -1.01 60.48 -26.21 q24.19 -25.2 24.19 -61.99 q0 -36.79 -24.19 -61.48
                         q-24.19 -24.7 -60.48 -26.71 ZM512 1024 q-217.7 -6.05 -361.82 -150.17 q-144.13 -144.13 -150.18 -361.83
                         q6.05 -217.7 150.18 -361.82 q144.13 -144.13 361.82 -150.18 q217.7 6.05 361.83 150.18 q144.13 144.13 150.17 361.82
                         q-6.05 217.7 -150.17 361.83 q-144.13 144.13 -361.83 150.17 ZM512 946.39 q184.44 -5.04 306.89 -127.5
                         q122.46 -122.45 127.5 -306.89 q-5.04 -184.44 -127.5 -306.89 q-122.45 -122.46 -306.89 -127.5 q-184.44 5.04 -306.89 127.5
                         q-122.46 122.45 -127.5 306.89 q5.04 184.44 127.5 306.89 q122.45 122.46 306.89 127.5 Z",
                Fill = "#FF000000"
            };

            BindingEmail = new VectorImage
            {
                Height = 20,
                Width = 20,
                Data = @"M512 1024 q-218 -5 -362.5 -149.5 q-144.5 -144.5 -149.5 -362.5 q5 -218 149.5 -362.5 q144.5 -144.5 362.5 -149.5
                         q218 5 362.5 149.5 q144.5 144.5 149.5 362.5 q-5 218 -149.5 362.5 q-144.5 144.5 -362.5 149.5 ZM282 278 l214 164
                         q8 6 16 6 q8 0 16 -6 l214 -164 l0 257 l-230 77 l-230 -77 l0 -257 ZM305 232 q7 -2 15 -2 l384 0 q8 0 15 2 q-3 2 -5 4
                         l-202 154 l-202 -154 q-2 -2 -5 -4 ZM794 518 l0 -262 q-1 -34 -27 -55 q-26 -21 -63 -22 l-384 0 q-37 1 -63 22
                         q-26 21 -27 55 l0 262 l-9 -3 q-25 -8 -46 7 q-21 15 -21 41 l0 154 q1 43 29.5 72 q28.5 29 72.5 30 l512 0 q44 -1 72.5 -30
                         q28.5 -29 29.5 -72 l0 -154 q0 -26 -21 -41 q-21 -15 -46 -7 l-9 3 ZM205 563 l307 103 l307 -103 l0 154 q0 21 -15 36
                         q-15 15 -36 15 l-512 0 q-22 -1 -36.5 -15 q-14.5 -14 -14.5 -36 l0 -154 Z",
                Fill = "#FF000000"
            };

            BindingPhone = new VectorImage
            {
                Height = 20,
                Width = 20,
                Data = @"M512 1024 q-218 -5 -362.5 -149.5 q-144.5 -144.5 -149.5 -362.5 q5 -218 149.5 -362.5 q144.5 -144.5 362.5 -149.5
                         q218 5 362.5 149.5 q144.5 144.5 149.5 362.5 q-5 218 -149.5 362.5 q-144.5 144.5 -362.5 149.5 ZM307 614 l0 -307
                         l410 0 l0 461 q0 21 -15 36 q-15 15 -36 15 l-308 0 q-21 0 -35.5 -14.5 q-14.5 -14.5 -15.5 -36.5 l0 -102 l333 0
                         q11 -1 18 -8 q7 -7 7 -18 q0 -11 -7 -18 q-7 -7 -18 -8 l-333 0 ZM307 256 q0 -21 15 -36 q15 -15 36 -15 l308 0
                         q21 0 36 15 q15 15 15 36 l-410 0 ZM358 154 q-43 1 -72 29.5 q-29 28.5 -30 72.5 l0 512 q1 44 30 72.5 q29 28.5 72 29.5
                         l308 0 q43 -1 72 -29.5 q29 -28.5 30 -72.5 l0 -512 q-1 -44 -30 -72.5 q-29 -28.5 -72 -29.5 l-308 0 ZM512 794
                         q22 -1 36.5 -15.5 q14.5 -14.5 14.5 -36 q0 -21.5 -14.5 -36 q-14.5 -14.5 -36.5 -14.5 q-22 0 -36.5 14.5 q-14.5 14.5 -14.5 36
                         q0 21.5 14.5 36 q14.5 14.5 36.5 15.5 Z",
                Fill = "#FF000000"
            };

            FavoriteOutline = new VectorImage
            {
                Height = 24,
                Width = 24,
                Data = @"M755.8 1021.89 q-13.98 -1 -28.45 -4.5 q-14.47 -3.5 -29.45 -8.49 l-146.74 -76.87 q-18.97 -13.97 -39.93 -13.97
                         q-20.97 0 -35.94 13.97 l-146.75 76.87 q-33.94 14.97 -69.38 12.98 q-35.44 -2 -65.39 -25.96 q-23.96 -19.96 -35.44 -49.41
                         q-11.48 -29.45 -2.5 -59.4 l31.95 -184.68 q3.99 -22.96 -3.49 -40.43 q-7.49 -17.47 -22.47 -36.43 l-126.77 -133.77
                         q-24.96 -19.96 -32.45 -50.41 q-7.49 -30.45 6.49 -64.39 q9.98 -28.95 34.94 -49.91 q24.96 -20.97 54.9 -26.96
                         l171.71 -24.95 q19.96 -1 36.93 -12.98 q16.97 -11.98 26.95 -31.94 l69.88 -159.73 q14.98 -33.94 45.42 -53.91
                         q30.44 -19.97 69.38 -15.97 q34.94 0 60.39 20.96 q25.45 20.96 35.44 55.9 l76.86 152.74 q9.98 18.96 26.96 32.44
                         q16.98 13.48 36.93 18.47 l172.7 25.95 q28.95 4.99 51.91 22.96 q22.96 17.97 36.93 46.92 q9.99 28.95 5 59.89
                         q-5 30.95 -23.96 54.91 l-127.78 133.77 q-14.97 14.97 -22.46 33.94 q-7.49 18.97 -3.49 42.92 l31.94 184.68
                         q4.99 34.94 -8.49 65.39 q-13.48 30.45 -42.43 50.41 q-13.98 8.98 -32.44 13.98 q-18.47 5 -37.44 5 ZM513.22 817.24
                         q23.96 0 46.92 5.99 q22.96 5.99 42.93 19.97 l139.75 75.87 q9.99 4.99 15.48 2.99 q5.49 -2 10.48 -2.49
                         q4.99 -0.5 7.99 -4.99 q3 -4.5 -2 -14.48 l-31.95 -184.68 q-4.99 -47.92 6.49 -87.35 q11.48 -39.43 44.42 -72.37
                         l127.78 -133.77 q3.99 -4.99 2.5 -9.98 q-1.5 -4.99 -2 -9.48 q-0.5 -4.5 -4.49 -5.49 q-3.99 -1 -8.99 -1 l-171.7 -24.96
                         q-43.92 -5.99 -79.86 -32.44 q-35.94 -26.45 -60.89 -70.38 l-69.88 -159.72 q0 -8.99 -4 -10.98 q-4 -2 -8.99 -2
                         q-4.99 0 -9.48 2 q-4.49 1.99 -9.48 10.98 l-69.88 159.72 q-24.96 43.92 -61.39 70.38 q-36.44 26.45 -79.37 32.44
                         l-172.7 24.96 q-4.99 0 -8.48 3.99 q-3.5 3.99 -3.99 8.98 q-0.49 5 0.5 8.99 q1 3.99 5.99 3.99 l127.78 133.77
                         q32.94 33.94 44.42 71.88 q11.48 37.93 6.49 80.85 l-25.95 185.68 q0 4.99 1 9.49 q1 4.5 5.99 9.49 q5 4.99 13.48 4.99
                         q8.49 0 18.47 -4.99 l139.76 -76.87 q10.98 -4.99 31.44 -11.48 q20.47 -6.49 45.42 -7.49 Z",
                Fill = "#FF000000"
            };

            BangumiFollow = new VectorImage
            {
                Height = 24,
                Width = 24,
                Data = @"M512 945.07 q-6.15 0 -13.53 -2.46 q-7.39 -2.46 -13.54 -4.92 q-43.07 -32 -190.74 -153.83 q-147.67 -121.83 -211.65 -200.59
                         q-51.69 -68.91 -67.69 -119.97 q-16 -51.06 -14.77 -116.29 q3.69 -146.44 91.06 -244.88 q87.37 -98.45 220.27 -102.14
                         q56.6 0 107.67 20.3 q51.07 20.3 92.91 58.46 q41.84 -38.15 92.91 -58.46 q51.07 -20.3 107.67 -20.3
                         q132.9 3.69 220.27 102.14 q87.37 98.45 91.06 244.88 q1.23 61.53 -14.76 113.21 q-16 51.68 -67.68 123.05
                         q-63.98 76.3 -212.88 199.36 q-148.9 123.06 -189.51 155.06 q-6.15 2.46 -13.54 4.92 q-7.38 2.46 -13.53 2.46 ZM322.49 78.76
                         q-97.21 3.69 -168.58 85.52 q-71.37 81.83 -75.07 197.5 q-1.23 35.69 8 79.99 q9.23 44.3 51.07 105.83 q44.3 52.91 163.66 148.9
                         l210.43 169.81 l210.43 -169.81 q119.36 -95.99 163.66 -148.9 q43.07 -61.53 52.3 -107.06 q9.23 -45.53 6.77 -78.76
                         q-3.7 -115.67 -75.07 -197.5 q-71.37 -81.83 -168.58 -85.52 q-49.23 0 -87.38 21.53 q-38.14 21.53 -78.75 57.21
                         q-11.07 8.62 -17.23 10.47 q-6.15 1.84 -6.15 1.84 l-4.92 -1.23 q-6.16 -1.23 -14.77 -7.39 q-43.07 -35.68 -81.83 -58.44
                         q-38.76 -22.77 -87.99 -23.99 Z",
                Fill = "#FF000000"
            };

            Toview = new VectorImage
            {
                Height = 24,
                Width = 24,
                Data = @"M837.18 92.91 q38.96 1 65.44 27.48 q26.48 26.48 27.48 65.43 l0 651.36 q-1 39.96 -27.48 65.94
                         q-26.48 25.98 -65.44 26.98 l-651.36 0 q-38.96 -1 -65.43 -26.98 q-26.48 -25.98 -27.48 -65.94 l0 -651.36
                         q1 -38.96 27.48 -65.43 q26.48 -26.48 65.43 -27.48 l651.36 0 ZM837.18 0 l-651.36 0 q-78.92 2 -131.37 54.45
                         q-52.45 52.45 -54.45 131.37 l0 651.36 q2 78.93 54.45 131.38 q52.45 52.44 131.37 54.44 l651.36 0 q78.93 -2 131.88 -54.44
                         q52.94 -52.45 54.94 -131.38 l0 -651.36 q-3 -78.92 -55.44 -131.37 q-52.45 -52.45 -131.38 -54.45 ZM697.32 744.27
                         q-12.99 0 -24.98 -7.99 l-242.76 -159.84 q-20.98 -13.99 -20.98 -38.96 l0 -278.73 q0 -19.98 12.99 -33.47
                         q12.99 -13.49 32.97 -13.49 q19.98 0 32.96 13.49 q12.99 13.49 13.99 33.47 l0 252.75 l221.78 143.86
                         q17.99 7.99 24.98 24.98 q6.99 16.99 0 35.96 q-6.99 14.99 -20.98 22.48 q-13.99 7.49 -29.97 5.49 Z",
                Fill = "#FF000000"
            };

            History = new VectorImage
            {
                Height = 24,
                Width = 24,
                Data = @"M512 0 q-217 6 -361.5 150.5 q-144.5 144.5 -150.5 361.5 q6 217 150.5 361.5 q144.5 144.5 361.5 150.5
                         q217 -6 361.5 -150.5 q144.5 -144.5 150.5 -361.5 q-6 -217 -150.5 -361.5 q-144.5 -144.5 -361.5 -150.5 ZM512 939
                         q-183 -5 -302.5 -124.5 q-119.5 -119.5 -124.5 -302.5 q5 -183 124.5 -302.5 q119.5 -119.5 302.5 -124.5
                         q183 5 302.5 124.5 q119.5 119.5 124.5 302.5 q-5 183 -124.5 302.5 q-119.5 119.5 -302.5 124.5 ZM512 256
                         l-85 0 l0 341 l341 0 l0 -85 l-256 0 l0 -256 Z",
                Fill = "#FF000000"
            };
        }

        public VectorImage Play { get; private set; }
        public VectorImage Like { get; private set; }
        public VectorImage Favorite { get; private set; }
        public VectorImage Share { get; private set; }

        public VectorImage CloudDownload { get; private set; }
        public VectorImage Folder { get; private set; }
        public VectorImage Downloading { get; private set; }
        public VectorImage DownloadFinished { get; private set; }

        public VectorImage CoinIcon { get; private set; }
        public VectorImage MoneyIcon { get; private set; }
        public VectorImage BindingEmail { get; private set; }
        public VectorImage BindingPhone { get; private set; }

        public VectorImage FavoriteOutline { get; private set; }
        public VectorImage BangumiFollow { get; private set; }
        public VectorImage Toview { get; private set; }
        public VectorImage History { get; private set; }
    }
}
