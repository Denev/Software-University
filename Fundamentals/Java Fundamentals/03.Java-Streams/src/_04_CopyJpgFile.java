/*
Write a program that copies the contents of a .jpg file to another using FileInputStream, FileOutputStream, and byte[] buffer.
Set the name of the new file as my-copied-picture.jpg.
*/

import java.io.*;

public class _04_CopyJpgFile {
    public static void main(String[] args) {
        try {
            InputStream image = new BufferedInputStream(new FileInputStream("resources/_04_CopyJpgFileResources/image.jpg"));
            OutputStream copiedImage = new BufferedOutputStream(new FileOutputStream("resources/_04_CopyJpgFileResources/my-copied-picture.jpg"));

            byte[] b = new byte[4096];
            int length;

            while ((length = image.read(b)) != -1) {
                copiedImage.write(b, 0, length);
            }

            image.close();
            copiedImage.close();
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }


    }

}

