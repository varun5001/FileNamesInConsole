import java.io.File;


public class FileNamesInConsole {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		String inputPath = "C:\\Jaffa\\";
		File folder = null;
		try{
			folder = new File(inputPath);
			
		}
		catch(Exception e){
			e.printStackTrace();
		}	
		File[] listOfFiles = folder.listFiles();
		for(int index = 0; index < listOfFiles.length; index++){
			if(listOfFiles[index].isFile())
				System.out.println(listOfFiles[index].getName());
		}
			

	}

}
